// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountRiskControlsPayouts : StripeEntity<AccountRiskControlsPayouts>
    {
        [JsonProperty("pause_requested")]
        public bool PauseRequested { get; set; }
    }
}
