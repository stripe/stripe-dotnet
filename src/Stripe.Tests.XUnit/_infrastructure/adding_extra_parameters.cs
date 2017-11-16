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
    public class adding_extra_parameters
    {
        public class TestOptions : StripeBaseOptions
        {
            [JsonProperty("a_string")]
            public string AString { get; set; }
        }

        public class TestService : StripeService
        {
            public TestService() : base(null)
            {
            }
        }

        public TestService Service { get; }

        public adding_extra_parameters()
        {
            Service = new TestService();
        }

        [Fact]
        public void can_add_extra_parameters()
        {
            var obj = new TestOptions
            {
                AString = "foo",
            };
            obj.AddExtraParam("extra_param", "some_value");
            obj.AddExtraParam("another_extra_param", "some_other_value");

            var url = Service.ApplyAllParameters(obj, "", false);
            url.Should().Be("?a_string=foo&extra_param=some_value&another_extra_param=some_other_value");
        }
    }
}
