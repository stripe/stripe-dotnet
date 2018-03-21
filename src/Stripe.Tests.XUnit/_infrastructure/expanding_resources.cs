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
    public class expanding_resources
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

        public expanding_resources()
        {
            Service = new TestService();
        }

        [Fact]
        public void can_expand_resources()
        {
            var obj = new TestOptions
            {
                AString = "foo",
            };
            obj.AddExpand("example1.subexample1");
            obj.AddExpand("example2");
            obj.AddExpand("example3.subexample3");

            var url = Service.ApplyAllParameters(obj, "", false);
            url.Should().Be("?a_string=foo&expand[]=example1.subexample1&expand[]=example2&expand[]=example3.subexample3");
        }
    }
}
