// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupIntentSetupDetails : StripeEntity<SetupIntentSetupDetails>
    {
        [JsonProperty("benefit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("benefit")]
#endif
        public SetupIntentSetupDetailsBenefit Benefit { get; set; }
    }
}
