// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountRiskControlsCharges : StripeEntity<AccountRiskControlsCharges>
    {
        [JsonProperty("pause_requested")]
        public bool PauseRequested { get; set; }
    }
}
