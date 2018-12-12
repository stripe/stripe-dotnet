namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Threading;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Stripe;
    using Stripe.Infrastructure;
    using StripeTests.Infrastructure.TestData;
    using Xunit;

    public class ParameterBuilderTest : BaseStripeTest
    {
        private TestService service;

        public ParameterBuilderTest()
        {
            this.service = new TestService();
        }

        [Fact]
        public void CanAddExtraParams()
        {
            var obj = new TestOptions();
            obj.AddExtraParam("extra_param", "some_value");
            obj.AddExtraParam("another_extra_param", "some_other_value");

            var url = this.service.ApplyAllParameters(obj, string.Empty, false);
            Assert.Contains("extra_param=some_value&another_extra_param=some_other_value", url);
        }

        [Fact]
        public void EncodesList()
        {
            Assert.NotNull(this.service);

            var testObject = new TestOptionsWithList();
            var url = this.service.ApplyAllParameters(testObject, string.Empty, false);

            Assert.Equal("?some_list[0][a_long]=1&some_list[0][a_string]=foo&some_list[1][a_long]=2&some_list[1][a_string]=bar", url);
        }

        [Fact]
        public void EncodesParameters()
        {
            Assert.NotNull(this.service);

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
                            Array = new [] { "1", "2", "3" },
                    },
                    want = "?array[0]=1&array[1]=2&array[2]=3"
                },
                new
                {
                    data = new TestOptions
                    {
                            Array = new string[] { },
                    },
                    want = "?array="
                },

                // Bool
                new
                {
                    data = new TestOptions
                    {
                        Bool = false,
                    },
                    want = "?bool=False"
                },
                new
                {
                    data = new TestOptions
                    {
                        Bool = true,
                    },
                    want = "?bool=True"
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
                    want = "?date_filter[gte]=946684800&date_filter[lt]=946702800"
                },

                // DateTime
                new
                {
                    data = new TestOptions
                    {
                        DateTime = DateTime.Parse("Sat, 01 Jan 2000 00:00:00Z"),
                    },
                    want = "?datetime=946684800"
                },

                // Decimal
                new
                {
                    data = new TestOptions
                    {
                        Decimal = 1.2345m,
                    },
                    want = "?decimal=1.2345"
                },
                new
                {
                    data = new TestOptions
                    {
                        Decimal = 0.0m,
                    },
                    want = "?decimal=0.0"
                },

                // Dictionary
                new
                {
                    data = new TestOptions
                    {
                            Dictionary = new Dictionary<string, object> { { "foo", "bar" } },
                    },
                    want = "?dictionary[foo]=bar"
                },
                new
                {
                    data = new TestOptions
                    {
                            Dictionary = new Dictionary<string, object> { { "empty", string.Empty } },
                    },
                    want = "?dictionary[empty]="
                },
                new
                {
                    data = new TestOptions
                    {
                            Dictionary = new Dictionary<string, object> { { "null", null } },
                    },
                    want = "?dictionary[null]="
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
                    want = "?dictionary[foo][bar]=baz"
                },

                // Enum
                new
                {
                    data = new TestOptions
                    {
                        Enum = TestOptions.TestEnum.TestOne,
                    },
                    want = "?enum=test_one"
                },
                new
                {
                    data = new TestOptions
                    {
                        Enum = TestOptions.TestEnum.TestTwo,
                    },
                    want = "?enum=TestTwo"
                },

                // List
                new
                {
                    data = new TestOptions
                    {
                            List = new List<object> { "foo", "bar" },
                    },
                    want = "?list[0]=foo&list[1]=bar"
                },
                new
                {
                    data = new TestOptions
                    {
                            List = new List<object> { string.Empty, 0 },
                    },
                    want = "?list[0]=&list[1]=0"
                },
                new
                {
                    data = new TestOptions
                    {
                            List = new List<object> { },
                    },
                    want = "?list="
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
                    want = "?list[0][foo]=bar&list[1][foo]=baz"
                },

                // Long
                new
                {
                    data = new TestOptions
                    {
                        Long = 123,
                    },
                    want = "?long=123"
                },
                new
                {
                    data = new TestOptions
                    {
                        Long = 0,
                    },
                    want = "?long=0"
                },

                // String
                new
                {
                    data = new TestOptions
                    {
                        String = "foo",
                    },
                    want = "?string=foo"
                },
                new
                {
                    data = new TestOptions
                    {
                        String = string.Empty,
                    },
                    want = "?string="
                },
            };

            foreach (var testCase in testCases)
            {
                var url = this.service.ApplyAllParameters(testCase.data, string.Empty, false);
                Assert.Equal(testCase.want, url);
            }
        }

        [Fact]
        public void EnumDecodeUnknownValue()
        {
            var json = "{\"enum\": \"TestTwo\"}";
            TestOptions obj = JsonConvert.DeserializeObject<TestOptions>(json);

            Assert.NotNull(obj);
            Assert.Equal(TestOptions.TestEnum.TestTwo, obj.Enum);
        }

        [Fact]
        public void EnumDecodeValidValue()
        {
            var json = "{\"enum\": \"test_one\"}";
            TestOptions obj = JsonConvert.DeserializeObject<TestOptions>(json);

            Assert.NotNull(obj);
            Assert.Equal(TestOptions.TestEnum.TestOne, obj.Enum);
        }

        [Fact]
        public void EnumEncodeUnknownValue()
        {
            var obj = new TestOptions
            {
                Enum = TestOptions.TestEnum.TestTwo,
            };
            var url = new TestService().ApplyAllParameters(obj, string.Empty, false);
            Assert.Contains("enum=TestTwo", url);
        }

        [Fact]
        public void EnumEncodeValidValue()
        {
            var obj = new TestOptions
            {
                Enum = TestOptions.TestEnum.TestOne,
            };
            var url = new TestService().ApplyAllParameters(obj, string.Empty, false);
            Assert.Contains("enum=test_one", url);
        }

        [Fact]
        public void ExpandServiceResource()
        {
            Assert.NotNull(this.service);

            this.service.ExpandSimple = true;
            this.service.ExpandMultiWordProperty = true;

            var url = this.service.ApplyAllParameters(new BaseOptions(), string.Empty, false);
            Assert.Equal("?expand[]=simple&expand[]=multi_word_property", url);
        }

        [Fact]
        public void ExpandServiceList()
        {
            Assert.NotNull(this.service);

            this.service.ExpandSimple = true;
            this.service.ExpandMultiWordProperty = true;

            var url = this.service.ApplyAllParameters(new BaseOptions(), string.Empty, true);
            Assert.Equal("?expand[]=data.simple&expand[]=data.multi_word_property", url);
        }

        [Fact]
        public void ExpandOptions()
        {
            var obj = new BaseOptions();
            obj.AddExpand("example1.subexample1");
            obj.AddExpand("example2");
            obj.AddExpand("example3.subexample3");

            var url = this.service.ApplyAllParameters(obj, string.Empty, false);
            Assert.Equal("?expand[]=example1.subexample1&expand[]=example2&expand[]=example3.subexample3", url);
        }

        [Fact]
        public void SetsUrl()
        {
            Assert.NotNull(this.service);

            var testObject = new TestOptions();
            var url = this.service.ApplyAllParameters(null, "base_url", false);
            Assert.Equal("base_url", url);
        }

        [Fact]
        public void DecodingShouldThrowIfValueNotDeclaredInEnum()
        {
            var json = "{\"enum\": \"unknown_value\"}";

            var exception = Assert.Throws<Newtonsoft.Json.JsonSerializationException>(() =>
                JsonConvert.DeserializeObject<TestOptions>(json));

            Assert.Contains("Error converting value \"unknown_value\"", exception.Message);
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

                var obj = new TestOptions
                {
                        Decimal = dec,
                };
                var url = this.service.ApplyAllParameters(obj, string.Empty, false);
                Assert.Equal("?decimal=123.45", url);
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
            var obj = new TestOptions
            {
                    Dictionary = new Dictionary<string, object>
                    {
                        { "#", "42" },
                        { "bar&baz", "+foo?" },
                    },
                    String = "[éàü]",
            };
            var url = this.service.ApplyAllParameters(obj, string.Empty, false);
            Assert.Equal("?dictionary[%23]=42&dictionary[bar%26baz]=%2Bfoo%3F&string=%5B%C3%A9%C3%A0%C3%BC%5D", url);
        }
    }
}
