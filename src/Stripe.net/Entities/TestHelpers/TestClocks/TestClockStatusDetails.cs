// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TestClockStatusDetails : StripeEntity<TestClockStatusDetails>
    {
        [JsonProperty("advancing")]
        [STJS.JsonPropertyName("advancing")]
        public TestClockStatusDetailsAdvancing Advancing { get; set; }
    }
}
