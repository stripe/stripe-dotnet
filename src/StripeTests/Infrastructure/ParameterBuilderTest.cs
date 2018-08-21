namespace StripeTests
{
    using System;
    using System.Collections.Generic;
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

            Assert.Equal("?some_list[0][an_int]=1&some_list[0][a_string]=foo&some_list[1][an_int]=2&some_list[1][a_string]=bar", url);
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
                    want = "?bool=False&decimal=0&enum=test_one&int=0"
                },

                // Array
                new
                {
                    data = new TestOptions
                    {
                            Array = new string[] { "1", "2", "3" },
                    },
                    want = "?array[0]=1&array[1]=2&array[2]=3&bool=False&decimal=0&enum=test_one&int=0"
                },
                new
                {
                    data = new TestOptions
                    {
                            Array = new string[] { },
                    },
                    want = "?array=&bool=False&decimal=0&enum=test_one&int=0"
                },

                // Bool
                new
                {
                    data = new TestOptions
                    {
                        Bool = false,
                    },
                    want = "?bool=False&decimal=0&enum=test_one&int=0"
                },
                new
                {
                    data = new TestOptions
                    {
                        Bool = true,
                    },
                    want = "?bool=True&decimal=0&enum=test_one&int=0"
                },

                // BoolNullable
                new
                {
                    data = new TestOptions
                    {
                        BoolNullable = false,
                    },
                    want = "?bool=False&bool_nullable=False&decimal=0&enum=test_one&int=0"
                },
                new
                {
                    data = new TestOptions
                    {
                        BoolNullable = true,
                    },
                    want = "?bool=False&bool_nullable=True&decimal=0&enum=test_one&int=0"
                },

                // DateFilter
                new
                {
                    data = new TestOptions
                    {
                        DateFilter = new DateFilter
                        {
                            EqualTo = DateTime.Parse("Sat, 01 Jan 2000 05:00:00Z"),
                        }
                    },
                    want = "?bool=False&date_filter=946702800&decimal=0&enum=test_one&int=0"
                },
                new
                {
                    data = new TestOptions
                    {
                        DateFilter = new DateFilter
                        {
                            LessThan = DateTime.Parse("Sat, 01 Jan 2000 05:00:00Z"),
                            GreaterThanOrEqual = DateTime.Parse("Sat, 01 Jan 2000 00:00:00Z"),
                        }
                    },
                    want = "?bool=False&date_filter[lt]=946702800&date_filter[gte]=946684800&decimal=0&enum=test_one&int=0"
                },

                // DateTimeNullable
                new
                {
                    data = new TestOptions
                    {
                        DateTimeNullable = DateTime.Parse("Sat, 01 Jan 2000 00:00:00Z"),
                    },
                    want = "?bool=False&datetime_nullable=946684800&decimal=0&enum=test_one&int=0"
                },

                // Decimal
                new
                {
                    data = new TestOptions
                    {
                        Decimal = 1.2345m,
                    },
                    want = "?bool=False&decimal=1.2345&enum=test_one&int=0"
                },
                new
                {
                    data = new TestOptions
                    {
                        Decimal = 0.0m,
                    },
                    want = "?bool=False&decimal=0.0&enum=test_one&int=0"
                },

                // DecimalNullable
                new
                {
                    data = new TestOptions
                    {
                        DecimalNullable = 1.2345m,
                    },
                    want = "?bool=False&decimal=0&decimal_nullable=1.2345&enum=test_one&int=0"
                },
                new
                {
                    data = new TestOptions
                    {
                        DecimalNullable = 0.0m,
                    },
                    want = "?bool=False&decimal=0&decimal_nullable=0.0&enum=test_one&int=0"
                },

                // Dictionary
                new
                {
                    data = new TestOptions
                    {
                            Dictionary = new Dictionary<string, object> { { "foo", "bar" } },
                    },
                    want = "?bool=False&decimal=0&dictionary[foo]=bar&enum=test_one&int=0"
                },
                new
                {
                    data = new TestOptions
                    {
                            Dictionary = new Dictionary<string, object> { { "empty", string.Empty } },
                    },
                    want = "?bool=False&decimal=0&dictionary[empty]=&enum=test_one&int=0"
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
                    want = "?bool=False&decimal=0&dictionary[foo][bar]=baz&enum=test_one&int=0"
                },

                // Enum
                new
                {
                    data = new TestOptions
                    {
                        Enum = TestOptions.TestEnum.TestOne,
                    },
                    want = "?bool=False&decimal=0&enum=test_one&int=0"
                },
                new
                {
                    data = new TestOptions
                    {
                        Enum = TestOptions.TestEnum.TestTwo,
                    },
                    want = "?bool=False&decimal=0&enum=TestTwo&int=0"
                },

                // EnumNullable
                new
                {
                    data = new TestOptions
                    {
                        EnumNullable = TestOptions.TestEnum.TestOne,
                    },
                    want = "?bool=False&decimal=0&enum=test_one&enum_nullable=test_one&int=0"
                },
                new
                {
                    data = new TestOptions
                    {
                        EnumNullable = TestOptions.TestEnum.TestTwo,
                    },
                    want = "?bool=False&decimal=0&enum=test_one&enum_nullable=TestTwo&int=0"
                },

                // Int
                new
                {
                    data = new TestOptions
                    {
                        Int = 123,
                    },
                    want = "?bool=False&decimal=0&enum=test_one&int=123"
                },
                new
                {
                    data = new TestOptions
                    {
                        Int = 0,
                    },
                    want = "?bool=False&decimal=0&enum=test_one&int=0"
                },

                // IntNullable
                new
                {
                    data = new TestOptions
                    {
                        IntNullable = 123,
                    },
                    want = "?bool=False&decimal=0&enum=test_one&int=0&int_nullable=123"
                },
                new
                {
                    data = new TestOptions
                    {
                        IntNullable = 0,
                    },
                    want = "?bool=False&decimal=0&enum=test_one&int=0&int_nullable=0"
                },

                // List
                new
                {
                    data = new TestOptions
                    {
                            List = new List<object> { "foo", "bar" },
                    },
                    want = "?bool=False&decimal=0&enum=test_one&int=0&list[0]=foo&list[1]=bar"
                },
                new
                {
                    data = new TestOptions
                    {
                            List = new List<object> { string.Empty, 0 },
                    },
                    want = "?bool=False&decimal=0&enum=test_one&int=0&list[0]=&list[1]=0"
                },
                new
                {
                    data = new TestOptions
                    {
                            List = new List<object> { },
                    },
                    want = "?bool=False&decimal=0&enum=test_one&int=0&list="
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
                    want = "?bool=False&decimal=0&enum=test_one&int=0&list[0][foo]=bar&list[1][foo]=baz"
                },

                // String
                new
                {
                    data = new TestOptions
                    {
                        String = "foo",
                    },
                    want = "?bool=False&decimal=0&enum=test_one&int=0&string=foo"
                },
                new
                {
                    data = new TestOptions
                    {
                        String = string.Empty,
                    },
                    want = "?bool=False&decimal=0&enum=test_one&int=0&string="
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
    }
}
