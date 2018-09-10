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

            var testObject = new TestOptions
            {
                StringContainingText = "Foo",
                StringWithDifferentName = string.Empty,
                Number = 42,
                Metadata = new Dictionary<string, string>
                {
                    { "A", "Value-A" },
                    { "B", "Value-B" },
                    { "empty_value", string.Empty },
                },
                ListOfDecimals = new List<decimal> { 1.5m, 2.6m, 3.7m },
                ArrayOfInts = new int[] { 7, 8, 9 },
                EqualDateFilter = new StripeDateFilter
                {
                    EqualTo = DateTime.Parse("Sat, 01 Jan 2000 05:00:00Z"),
                },
                LessThanDateFilter = new StripeDateFilter
                {
                    LessThan = DateTime.Parse("Sat, 01 Jan 2000 05:00:00Z"),
                },
                ComplexDateFilter = new StripeDateFilter
                {
                    LessThan = DateTime.Parse("Mon, 01 Jan 2001 00:00:00Z"),
                    GreaterThan = DateTime.Parse("Sat, 01 Jan 2000 05:00:00Z"),
                },
            };
            var url = this.service.ApplyAllParameters(testObject, string.Empty, false);
            Console.WriteLine(url);
            Assert.Equal(
                "?differentname=" +
                "&stringcontainingtext=Foo" +
                "&number=42" +
                "&metadata[A]=Value-A&metadata[B]=Value-B&metadata[empty_value]=" +
                "&list_of_decimals[0]=1.5&list_of_decimals[1]=2.6&list_of_decimals[2]=3.7" +
                "&array_of_ints[0]=7&array_of_ints[1]=8&array_of_ints[2]=9" +
                "&dateequals=946702800" +
                "&datelessthan[lt]=946702800" +
                "&datecomplex[lt]=978307200&datecomplex[gt]=946702800",
                url);
            Assert.DoesNotContain("StringWithoutAttribute=", url);
            Assert.DoesNotContain("stringcontainingnull=", url);
            Assert.DoesNotContain("nullnumber=", url);
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

            var url = this.service.ApplyAllParameters(new StripeBaseOptions(), string.Empty, false);
            Assert.Equal("?expand[]=simple&expand[]=multi_word_property", url);
        }

        [Fact]
        public void ExpandServiceList()
        {
            Assert.NotNull(this.service);

            this.service.ExpandSimple = true;
            this.service.ExpandMultiWordProperty = true;

            var url = this.service.ApplyAllParameters(new StripeBaseOptions(), string.Empty, true);
            Assert.Equal("?expand[]=data.simple&expand[]=data.multi_word_property", url);
        }

        [Fact]
        public void ExpandOptions()
        {
            var obj = new StripeBaseOptions();
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
        public void decoding_should_throw_if_value_not_declared_in_enum()
        {
            var json = "{\"enum\": \"unknown_value\"}";

            var exception = Assert.Throws<Newtonsoft.Json.JsonSerializationException>(() =>
                JsonConvert.DeserializeObject<TestOptions>(json));

            Assert.Contains("Error converting value \"unknown_value\"", exception.Message);
        }
    }
}
