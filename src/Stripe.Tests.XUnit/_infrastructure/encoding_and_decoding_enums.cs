using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using FluentAssertions;
using Xunit;
using Stripe.Infrastructure;

namespace Stripe.Tests.Xunit
{
    public class encoding_and_decoding_enums
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TestEnum
        {
            [EnumMember(Value = "test_one")]
            TestOne,

            // TestTwo doesn't define a serialization value
            TestTwo,
        }

        public class TestObject : StripeBaseOptions
        {
            [JsonProperty("enum")]
            public TestEnum? Enum { get; set; }
        }

        public class TestService : StripeService
        {
            public TestService() : base(null)
            {
            }
        }

        public encoding_and_decoding_enums()
        {
        }

        [Fact]
        public void encoding_should_use_enummember_value_if_it_exists()
        {
            var obj = new TestObject
            {
                Enum = TestEnum.TestOne,
            };
            var url = new TestService().ApplyAllParameters(obj, "", false);
            url.Should().Be("?enum=test_one");
        }

        [Fact]
        public void encoding_should_convert_to_string_if_no_enummember_value()
        {
            var obj = new TestObject
            {
                Enum = TestEnum.TestTwo,
            };
            var url = new TestService().ApplyAllParameters(obj, "", false);
            url.Should().Be("?enum=TestTwo");
        }

        [Fact]
        public void decoding_should_use_enummember_value_if_it_exists()
        {
            var json = "{\"enum\": \"test_one\"}";
            TestObject obj = JsonConvert.DeserializeObject<TestObject>(json);

            obj.Should().NotBeNull();
            obj.Enum.Should().Be(TestEnum.TestOne);
        }

        [Fact]
        public void decoding_should_use_string_if_no_enummember_value()
        {
            var json = "{\"enum\": \"TestTwo\"}";
            TestObject obj = JsonConvert.DeserializeObject<TestObject>(json);

            obj.Should().NotBeNull();
            obj.Enum.Should().Be(TestEnum.TestTwo);
        }

        [Fact]
        public void decoding_should_throw_if_value_not_declared_in_enum()
        {
            var json = "{\"enum\": \"unknown_value\"}";

            var exception = Assert.Throws<Newtonsoft.Json.JsonSerializationException>(() =>
                (JsonConvert.DeserializeObject<TestObject>(json))
            );

            exception.Message.Should().Contain("Error converting value \"unknown_value\"");
        }
    }
}
