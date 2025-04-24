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

    public class ContentEncoderTest : BaseStripeTest
    {
        [Fact]
        public async Task CreateHttpContent_Null()
        {
            var content = ContentEncoder.CreateHttpContent(null, ApiMode.V1);

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
            var content = ContentEncoder.CreateHttpContent(options, ApiMode.V1);

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
        public async Task CreateHttpContent_NoStream_V2()
        {
            var options = new TestOptions
            {
                List = new List<object> { 1, 2, 3 },
                String = "String!",
            };
            var content = ContentEncoder.CreateHttpContent(options, ApiMode.V2);

            Assert.NotNull(content);
            Assert.IsType<JsonEncodedContent>(content);

            Assert.Equal("application/json", content.Headers.ContentType.MediaType);
            Assert.Equal("utf-8", content.Headers.ContentType.CharSet);
            Assert.Equal(1, content.Headers.ContentType.Parameters.Count);

            var stream = await content.ReadAsStreamAsync();
            var result = new StreamReader(stream).ReadToEnd();
            Assert.Equal("{\"list\":[1,2,3],\"string\":\"String!\"}", result);
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
            var content = ContentEncoder.CreateHttpContent(options, ApiMode.V1);

            Assert.NotNull(content);
            Assert.IsType<MultipartFormDataContent>(content);

            Assert.Equal("multipart/form-data", content.Headers.ContentType.MediaType);
            Assert.Equal(1, content.Headers.ContentType.Parameters.Count);

            var stream = await content.ReadAsStreamAsync();
            Assert.Equal(764, stream.Length);
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
                "Content-Disposition: form-data; name=\"stream\"; filename=blob; filename*=utf-8''blob\r\nContent-Type: application/octet-stream\r\n\r\nHello World!\r\n",
                result);
            Assert.Contains(
                "Content-Type: text/plain; charset=utf-8\r\nContent-Disposition: form-data; name=\"string\"\r\n\r\nString!\r\n",
                result);
        }

        [Fact]
        public void CreateQueryString()
        {
            var testCases = new[]
            {
                // No data
                new QueryStringTestCase
                {
                    Data = new TestOptions { },
                    Want = string.Empty,
                },

                // AnyOf
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        AnyOf = "foo",
                    },
                    Want = "any_of=foo",
                },
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        AnyOf = new Dictionary<string, string> { { "foo", "bar" } },
                    },
                    Want = "any_of[foo]=bar",
                },
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        AnyOf = null, // AnyOf itself is null
                    },
                    Want = string.Empty,
                },
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        AnyOf = (string)null, // AnyOf is not null but AnyOf.Value is null
                    },
                    Want = string.Empty,
                },
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        AnyOf = (Dictionary<string, string>)null, // same as above, AnyOf.Value is null
                    },
                    Want = string.Empty,
                },

                // Array
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                            Array = new[] { "1", "2", "3" },
                    },
                    Want = "array[0]=1&array[1]=2&array[2]=3",
                },
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                            Array = new string[] { },
                    },
                    Want = "array=",
                },

                // V2 Array
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                            Array = new[] { "1", "2", "3" },
                    },
                    Want = "array=1&array=2&array=3",
                    Mode = ApiMode.V2,
                },

                // Bool
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        Bool = false,
                    },
                    Want = "bool=false",
                },
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        Bool = true,
                    },
                    Want = "bool=true",
                },

                // DateRangeOptions
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        DateRangeOptions = new DateRangeOptions
                        {
                            LessThan = DateTime.Parse("Sat, 01 Jan 2000 05:00:00Z"),
                            GreaterThanOrEqual = DateTime.Parse("Sat, 01 Jan 2000 00:00:00Z"),
                        },
                    },
                    Want = "date_filter[gte]=946684800&date_filter[lt]=946702800",
                },

                // DateTime
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        DateTime = DateTime.Parse("Sat, 01 Jan 2000 00:00:00Z"),
                    },
                    Want = "datetime=946684800",
                },

                // Decimal
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        Decimal = 1.2345m,
                    },
                    Want = "decimal=1.2345",
                },
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        Decimal = 0.0m,
                    },
                    Want = "decimal=0.0",
                },

                // Dictionary
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        Dictionary = new Dictionary<string, object> { { "foo", "bar" } },
                    },
                    Want = "dictionary[foo]=bar",
                },
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        Dictionary = new Dictionary<string, object> { { "empty", string.Empty } },
                    },
                    Want = "dictionary[empty]=",
                },
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        Dictionary = new Dictionary<string, object> { { "null", null } },
                    },
                    Want = "dictionary[null]=",
                },
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        Dictionary = new Dictionary<string, object>
                        {
                            { "foo", new Dictionary<string, object> { { "bar", "baz" } } },
                        },
                    },
                    Want = "dictionary[foo][bar]=baz",
                },

                // Enum
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        Enum = TestOptions.TestEnum.TestOne,
                    },
                    Want = "enum=test_one",
                },
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        Enum = TestOptions.TestEnum.TestTwo,
                    },
                    Want = "enum=TestTwo",
                },

                // List
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        List = new List<object> { "foo", "bar" },
                    },
                    Want = "list[0]=foo&list[1]=bar",
                },
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        List = new List<object> { string.Empty, 0 },
                    },
                    Want = "list[0]=&list[1]=0",
                },
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        List = new List<object> { },
                    },
                    Want = "list=",
                },
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        List = new List<object>
                        {
                            new Dictionary<string, object> { { "foo", "bar" } },
                            new Dictionary<string, object> { { "foo", "baz" } },
                        },
                    },
                    Want = "list[0][foo]=bar&list[1][foo]=baz",
                },

                // Long
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        Long = 123,
                    },
                    Want = "long=123",
                },
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        Long = 0,
                    },
                    Want = "long=0",
                },

                // String
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        String = "foo",
                    },
                    Want = "string=foo",
                },
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        String = string.Empty,
                    },
                    Want = "string=",
                },

                // StringEnum
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        StringEnum = TestOptions.TestStringEnum.Foo,
                    },
                    Want = "string_enum=foo",
                },
                new QueryStringTestCase
                {
                    Data = new TestOptions
                    {
                        StringEnum = null,
                    },
                    Want = string.Empty,
                },
            };

            foreach (var testCase in testCases)
            {
                Assert.Equal(testCase.Want, ContentEncoder.CreateQueryString(testCase.Data, testCase.Mode));
            }
        }

        [Fact]
        public void EnumEncodeUnknownValue()
        {
            var options = new TestOptions
            {
                Enum = TestOptions.TestEnum.TestTwo,
            };
            Assert.Equal("enum=TestTwo", ContentEncoder.CreateQueryString(options));
        }

        [Fact]
        public void EnumEncodeValidValue()
        {
            var options = new TestOptions
            {
                Enum = TestOptions.TestEnum.TestOne,
            };
            Assert.Contains("enum=test_one", ContentEncoder.CreateQueryString(options));
        }

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
                Assert.Equal("decimal=123.45", ContentEncoder.CreateQueryString(options));
            }
            finally
            {
                Thread.CurrentThread.CurrentCulture = currentCulture;
            }
        }

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
                ContentEncoder.CreateQueryString(options));
        }

        private class QueryStringTestCase
        {
            public TestOptions Data { get; set; }

            public string Want { get; set; }

            public ApiMode Mode { get; set; } = ApiMode.V1;
        }
    }
}
