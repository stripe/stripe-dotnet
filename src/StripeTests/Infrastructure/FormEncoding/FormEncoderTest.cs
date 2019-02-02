namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Threading;
    using Stripe;
    using Stripe.Infrastructure.FormEncoding;
    using StripeTests.Infrastructure.TestData;
    using Xunit;

    public class FormEncoderTest : BaseStripeTest
    {
        [Fact]
        public void EncodeOptions()
        {
            var testCases = new[]
            {
                // No data
                new
                {
                    data = new TestOptions { },
                    want = string.Empty
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
                Assert.Equal(testCase.want, FormEncoder.EncodeOptions(testCase.data));
            }
        }

        [Fact]
        public void EnumEncodeUnknownValue()
        {
            var options = new TestOptions
            {
                Enum = TestOptions.TestEnum.TestTwo,
            };
            Assert.Equal("enum=TestTwo", FormEncoder.EncodeOptions(options));
        }

        [Fact]
        public void EnumEncodeValidValue()
        {
            var options = new TestOptions
            {
                Enum = TestOptions.TestEnum.TestOne,
            };
            Assert.Contains("enum=test_one", FormEncoder.EncodeOptions(options));
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
                Assert.Equal("decimal=123.45", FormEncoder.EncodeOptions(options));
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
                FormEncoder.EncodeOptions(options));
        }
    }
}
