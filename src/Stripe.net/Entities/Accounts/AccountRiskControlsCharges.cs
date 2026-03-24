// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountRiskControlsCharges : StripeEntity<AccountRiskControlsCharges>
    {
        /// <summary>
        /// Whether a pause of the risk control has been requested.
        /// </summary>
        [JsonProperty("pause_requested")]
        [STJS.JsonPropertyName("pause_requested")]
        public bool PauseRequested { get; set; }
    }
}
