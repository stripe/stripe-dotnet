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
    public class encoding_lists_of_objects
    {
        public class TestItem : INestedOptions
        {
            [JsonProperty("an_int")]
            public int? AnInt { get; set; }

            [JsonProperty("a_string")]
            public string AString { get; set; }
        }

        public class TestObject : StripeBaseOptions
        {
            [JsonProperty("some_list")]
            public List<TestItem> SomeList { get; set; }
        }

        public class TestService : StripeService
        {
            public TestService() : base(null)
            {
            }
        }

        public encoding_lists_of_objects()
        {
        }

        [Fact]
        public void encoding_should_use_enummember_value_if_it_exists()
        {
            var obj = new TestObject
            {
                SomeList = new List<TestItem>
                {
                    new TestItem {AnInt = 1, AString = "foo"},
                    new TestItem {AnInt = 2, AString = "bar"},
                },
            };
            var url = new TestService().ApplyAllParameters(obj, "", false);
            url.Should().Be("?some_list[0][an_int]=1&some_list[0][a_string]=foo&some_list[1][an_int]=2&some_list[1][a_string]=bar");
        }
    }
}
