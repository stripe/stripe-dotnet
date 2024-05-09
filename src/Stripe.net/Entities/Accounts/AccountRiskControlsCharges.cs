// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountRiskControlsCharges : StripeEntity<AccountRiskControlsCharges>
    {
        /// <summary>
        /// Whether a pause of the risk control has been requested.
        /// </summary>
        [JsonProperty("pause_requested")]
        public bool PauseRequested { get; set; }
    }
}
