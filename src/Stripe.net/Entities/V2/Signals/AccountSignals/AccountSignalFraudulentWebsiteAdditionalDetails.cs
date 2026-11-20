// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSignalFraudulentWebsiteAdditionalDetails : StripeEntity<AccountSignalFraudulentWebsiteAdditionalDetails>
    {
        /// <summary>
        /// Human-readable explanation of the fraudulent website evaluation.
        /// </summary>
        [JsonProperty("explanation")]
        [STJS.JsonPropertyName("explanation")]
        public string Explanation { get; set; }
    }
}
