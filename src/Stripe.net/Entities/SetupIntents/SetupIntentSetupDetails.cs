// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SetupIntentSetupDetails : StripeEntity<SetupIntentSetupDetails>
    {
        [JsonProperty("benefit")]
        [STJS.JsonPropertyName("benefit")]
        public SetupIntentSetupDetailsBenefit Benefit { get; set; }
    }
}
