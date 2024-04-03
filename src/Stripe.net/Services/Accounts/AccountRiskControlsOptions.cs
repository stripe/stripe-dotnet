// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountRiskControlsOptions : INestedOptions
    {
        /// <summary>
        /// Represents the risk control status of charges. Please see <a
        /// href="https://stripe.com/docs/connect/pausing-payments-or-payouts-on-connected-accounts">this
        /// page for more details</a>.
        /// </summary>
        [JsonProperty("charges")]
        public AccountRiskControlsChargesOptions Charges { get; set; }

        /// <summary>
        /// Represents the risk control status of payouts. Please see <a
        /// href="https://stripe.com/docs/connect/pausing-payments-or-payouts-on-connected-accounts">this
        /// page for more details</a>.
        /// </summary>
        [JsonProperty("payouts")]
        public AccountRiskControlsPayoutsOptions Payouts { get; set; }
    }
}
