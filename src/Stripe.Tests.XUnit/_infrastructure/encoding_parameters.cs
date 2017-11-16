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
    public class encoding_parameters
    {
        public class TestObject : StripeBaseOptions
        {
            [JsonProperty("an_int")]
            public int? AnInt { get; set; }

            [JsonProperty("a_string")]
            public string AString { get; set; }

            [JsonProperty("a_dict")]
            public Dictionary<string, string> ADict { get; set; }

            [JsonProperty("a_list")]
            public int[] AList { get; set; }
        }

        public class UnencodableObject : StripeBaseOptions
        {
            [JsonProperty("dict_int_keys")]
            public Dictionary<int, string> DictIntKeys { get; set; }

            [JsonProperty("dict_int_values")]
            public Dictionary<string, int> DictIntValues { get; set; }
        }

        public class TestService : StripeService
        {
            public TestService() : base(null)
            {
            }
        }

        public TestService Service { get; }

        public encoding_parameters()
        {
            Service = new TestService();
        }

        [Fact]
        public void parameters_should_be_encoded()
        {
            var obj = new TestObject
            {
                AnInt = 3,
                AString = "+foo?",
                ADict = new Dictionary<string, string>
                {
                    {"a", "A"},
                    {"b", "B"},
                },
                AList = new int[] { 1, 2 },
            };
            var url = Service.ApplyAllParameters(obj, "", false);
            url.Should().Be("?an_int=3&a_string=%2Bfoo%3F&a_dict[a]=A&a_dict[b]=B&a_list[]=1&a_list[]=2");
        }

        [Fact]
        public void empty_strings_should_be_encoded()
        {
            var obj = new TestObject
            {
                AString = "",
            };
            var url = Service.ApplyAllParameters(obj, "", false);
            url.Should().Be("?a_string=");
        }

        [Fact]
        public void dictionary_keys_should_be_encoded()
        {
            var obj = new TestObject
            {
                ADict = new Dictionary<string, string>
                {
                    {"invoice #", "1234"},
                },
            };
            var url = Service.ApplyAllParameters(obj, "", false);
            url.Should().Be("?a_dict[invoice+%23]=1234");
        }

        [Fact]
        public void dictionary_values_should_be_encoded()
        {
            var obj = new TestObject
            {
                ADict = new Dictionary<string, string>
                {
                    {"invoice", "#1234"},
                },
            };
            var url = Service.ApplyAllParameters(obj, "", false);
            url.Should().Be("?a_dict[invoice]=%231234");
        }

        [Fact]
        public void throws_if_dictionary_keys_are_not_strings()
        {
            var obj = new UnencodableObject
            {
                DictIntKeys = new Dictionary<int, string>
                {
                    {1, "one"},
                },
            };

            var exception = Assert.Throws<System.ArgumentException>(() =>
                Service.ApplyAllParameters(obj, "", false)
            );

            exception.Message.Should().Contain("Expected System.String as dictionary key type");
        }

        [Fact]
        public void throws_if_dictionary_values_are_not_strings()
        {
            var obj = new UnencodableObject
            {
                DictIntValues = new Dictionary<string, int>
                {
                    {"one", 1},
                },
            };

            var exception = Assert.Throws<System.ArgumentException>(() =>
                Service.ApplyAllParameters(obj, "", false)
            );

            exception.Message.Should().Contain("Expected System.String as dictionary value type");
        }
    }
}
