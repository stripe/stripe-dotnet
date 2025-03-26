// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TestClockStatusDetails : StripeEntity<TestClockStatusDetails>
    {
        [JsonProperty("advancing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("advancing")]
#endif
        public TestClockStatusDetailsAdvancing Advancing { get; set; }
    }
}
