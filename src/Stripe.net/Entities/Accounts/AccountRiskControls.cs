// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountRiskControls : StripeEntity<AccountRiskControls>
    {
        [JsonProperty("charges")]
        public AccountRiskControlsCharges Charges { get; set; }

        [JsonProperty("payouts")]
        public AccountRiskControlsPayouts Payouts { get; set; }
    }
}
