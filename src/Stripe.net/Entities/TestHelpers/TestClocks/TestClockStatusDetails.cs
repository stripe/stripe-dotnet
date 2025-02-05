// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using Newtonsoft.Json;

    public class TestClockStatusDetails : StripeEntity<TestClockStatusDetails>
    {
        [JsonProperty("advancing")]
        public TestClockStatusDetailsAdvancing Advancing { get; set; }
    }
}
