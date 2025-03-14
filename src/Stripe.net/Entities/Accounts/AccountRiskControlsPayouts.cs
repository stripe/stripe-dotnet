// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountRiskControlsPayouts : StripeEntity<AccountRiskControlsPayouts>
    {
        /// <summary>
        /// Whether a pause of the risk control has been requested.
        /// </summary>
        [JsonProperty("pause_requested")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pause_requested")]
#endif
        public bool PauseRequested { get; set; }
    }
}
