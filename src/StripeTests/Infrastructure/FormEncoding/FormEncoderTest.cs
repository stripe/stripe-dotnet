namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe;
    using Stripe.Infrastructure.FormEncoding;
    using StripeTests.Infrastructure.TestData;
    using Xunit;

    public class FormEncoderTest : BaseStripeTest
    {
        [Fact]
        public async Task CreateHttpContent_Null()
        {
            var content = FormEncoder.CreateHttpContent(null);

            Assert.NotNull(content);
            Assert.IsType<FormUrlEncodedContent>(content);

            Assert.Equal("application/x-www-form-urlencoded", content.Headers.ContentType.MediaType);
            Assert.Equal("utf-8", content.Headers.ContentType.CharSet);
            Assert.Equal(1, content.Headers.ContentType.Parameters.Count);

            var stream = await content.ReadAsStreamAsync();
            Assert.Equal(0, stream.Length);
        }

        [Fact]
        public async Task CreateHttpContent_NoStream()
        {
            var options = new TestOptions
            {
                List = new List<object> { 1, 2, 3 },
                String = "String!",
            };
            var content = FormEncoder.CreateHttpContent(options);

            Assert.NotNull(content);
            Assert.IsType<FormUrlEncodedContent>(content);

            Assert.Equal("application/x-www-form-urlencoded", content.Headers.ContentType.MediaType);
            Assert.Equal("utf-8", content.Headers.ContentType.CharSet);
            Assert.Equal(1, content.Headers.ContentType.Parameters.Count);

            var stream = await content.ReadAsStreamAsync();
            Assert.Equal(44, stream.Length);
            var result = new StreamReader(stream).ReadToEnd();
            Assert.Equal("list[0]=1&list[1]=2&list[2]=3&string=String!", result);
        }

        [Fact]
        public async Task CreateHttpContent_Stream()
        {
            var options = new TestOptions
            {
                List = new List<object> { 1, 2, 3 },
                Stream = new MemoryStream(Encoding.UTF8.GetBytes("Hello World!")),
                String = "String!",
            };
            var content = FormEncoder.CreateHttpContent(options);

            Assert.NotNull(content);
            Assert.IsType<MultipartFormDataContent>(content);

            Assert.Equal("multipart/form-data", content.Headers.ContentType.MediaType);
            Assert.Equal(1, content.Headers.ContentType.Parameters.Count);

            var stream = await content.ReadAsStreamAsync();
            Assert.Equal(760, stream.Length);
            var result = new StreamReader(stream).ReadToEnd();

            // The boundary will be a random GUID, so we just check for substrings.
            // MultipartFormDataContentTest has more exhaustive tests with a non-random boundary.
            Assert.Contains(
                "Content-Type: text/plain; charset=utf-8\r\nContent-Disposition: form-data; name=\"list[0]\"\r\n\r\n1\r\n",
                result);
            Assert.Contains(
                "Content-Type: text/plain; charset=utf-8\r\nContent-Disposition: form-data; name=\"list[1]\"\r\n\r\n2\r\n",
                result);
            Assert.Contains(
                "Content-Type: text/plain; charset=utf-8\r\nContent-Disposition: form-data; name=\"list[2]\"\r\n\r\n3\r\n",
                result);
            Assert.Contains(
                "Content-Disposition: form-data; name=stream; filename=blob; filename*=utf-8''blob\r\nContent-Type: application/octet-stream\r\n\r\nHello World!\r\n",
                result);
            Assert.Contains(
                "Content-Type: text/plain; charset=utf-8\r\nContent-Disposition: form-data; name=string\r\n\r\nString!\r\n",
                result);
        }

        [Fact]
        public void CreateQueryString()
        {
            var testCases = new[]
            {
                // No data
                new
                {
                    data = new TestOptions { },
                    want = string.Empty
                },

                // AnyOf
                new
                {
                    data = new TestOptions
                    {
                        AnyOf = "foo",
                    },
                    want = "any_of=foo"
                },
                new
                {
                    data = new TestOptions
                    {
                        AnyOf = new Dictionary<string, string> { { "foo", "bar" } },
                    },
                    want = "any_of[foo]=bar"
                },

                // Array
                new
                {
                    data = new TestOptions
                    {
                            Array = new[] { "1", "2", "3" },
                    },
                    want = "array[0]=1&array[1]=2&array[2]=3"
                },
                new
                {
                    data = new TestOptions
                    {
                            Array = new string[] { },
                    },
                    want = "array="
                },

                // Bool
                new
                {
                    data = new TestOptions
                    {
                        Bool = false,
                    },
                    want = "bool=False"
                },
                new
                {
                    data = new TestOptions
                    {
                        Bool = true,
                    },
                    want = "bool=True"
                },

                // DateRangeOptions
                new
                {
                    data = new TestOptions
                    {
                        DateRangeOptions = new DateRangeOptions
                        {
                            LessThan = DateTime.Parse("Sat, 01 Jan 2000 05:00:00Z"),
                            GreaterThanOrEqual = DateTime.Parse("Sat, 01 Jan 2000 00:00:00Z"),
                        }
                    },
                    want = "date_filter[gte]=946684800&date_filter[lt]=946702800"
                },

                // DateTime
                new
                {
                    data = new TestOptions
                    {
                        DateTime = DateTime.Parse("Sat, 01 Jan 2000 00:00:00Z"),
                    },
                    want = "datetime=946684800"
                },

                // Decimal
                new
                {
                    data = new TestOptions
                    {
                        Decimal = 1.2345m,
                    },
                    want = "decimal=1.2345"
                },
                new
                {
                    data = new TestOptions
                    {
                        Decimal = 0.0m,
                    },
                    want = "decimal=0.0"
                },

                // Dictionary
                new
                {
                    data = new TestOptions
                    {
                        Dictionary = new Dictionary<string, object> { { "foo", "bar" } },
                    },
                    want = "dictionary[foo]=bar"
                },
                new
                {
                    data = new TestOptions
                    {
                        Dictionary = new Dictionary<string, object> { { "empty", string.Empty } },
                    },
                    want = "dictionary[empty]="
                },
                new
                {
                    data = new TestOptions
                    {
                        Dictionary = new Dictionary<string, object> { { "null", null } },
                    },
                    want = "dictionary[null]="
                },
                new
                {
                    data = new TestOptions
                    {
                        Dictionary = new Dictionary<string, object>
                        {
                            { "foo", new Dictionary<string, object> { { "bar", "baz" } } },
                        },
                    },
                    want = "dictionary[foo][bar]=baz"
                },

                // Enum
                new
                {
                    data = new TestOptions
                    {
                        Enum = TestOptions.TestEnum.TestOne,
                    },
                    want = "enum=test_one"
                },
                new
                {
                    data = new TestOptions
                    {
                        Enum = TestOptions.TestEnum.TestTwo,
                    },
                    want = "enum=TestTwo"
                },

                // List
                new
                {
                    data = new TestOptions
                    {
                        List = new List<object> { "foo", "bar" },
                    },
                    want = "list[0]=foo&list[1]=bar"
                },
                new
                {
                    data = new TestOptions
                    {
                        List = new List<object> { string.Empty, 0 },
                    },
                    want = "list[0]=&list[1]=0"
                },
                new
                {
                    data = new TestOptions
                    {
                        List = new List<object> { },
                    },
                    want = "list="
                },
                new
                {
                    data = new TestOptions
                    {
                        List = new List<object>
                        {
                            new Dictionary<string, object> { { "foo", "bar" } },
                            new Dictionary<string, object> { { "foo", "baz" } },
                        },
                    },
                    want = "list[0][foo]=bar&list[1][foo]=baz"
                },

                // Long
                new
                {
                    data = new TestOptions
                    {
                        Long = 123,
                    },
                    want = "long=123"
                },
                new
                {
                    data = new TestOptions
                    {
                        Long = 0,
                    },
                    want = "long=0"
                },

                // String
                new
                {
                    data = new TestOptions
                    {
                        String = "foo",
                    },
                    want = "string=foo"
                },
                new
                {
                    data = new TestOptions
                    {
                        String = string.Empty,
                    },
                    want = "string="
                },
            };

            foreach (var testCase in testCases)
            {
                Assert.Equal(testCase.want, FormEncoder.CreateQueryString(testCase.data));
            }
        }

        [Fact]
        public void EnumEncodeUnknownValue()
        {
            var options = new TestOptions
            {
                Enum = TestOptions.TestEnum.TestTwo,
            };
            Assert.Equal("enum=TestTwo", FormEncoder.CreateQueryString(options));
        }

        [Fact]
        public void EnumEncodeValidValue()
        {
            var options = new TestOptions
            {
                Enum = TestOptions.TestEnum.TestOne,
            };
            Assert.Contains("enum=test_one", FormEncoder.CreateQueryString(options));
        }

        #if !NETCOREAPP1_1
        [Fact]
        public void IgnoresCulture()
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture;

            try
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");

                var dec = 123.45m;
                Assert.Equal("123,45", dec.ToString(CultureInfo.CurrentCulture));

                var options = new TestOptions { Decimal = dec };
                Assert.Equal("decimal=123.45", FormEncoder.CreateQueryString(options));
            }
            finally
            {
                Thread.CurrentThread.CurrentCulture = currentCulture;
            }
        }
        #endif

        [Fact]
        public void UrlEncodesKeysAndValues()
        {
            var options = new TestOptions
            {
                    Dictionary = new Dictionary<string, object>
                    {
                        { "#", "1 2 3" },
                        { "bar&baz", "+foo?" },
                    },
                    String = "[éàü]",
            };
            Assert.Equal(
                "dictionary[%23]=1+2+3&dictionary[bar%26baz]=%2Bfoo%3F&string=[%C3%A9%C3%A0%C3%BC]",
                FormEncoder.CreateQueryString(options));
        }
    }
}
