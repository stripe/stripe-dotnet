// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountRiskControlsOptions : INestedOptions
    {
        /// <summary>
        /// Represents the risk control status of charges. Please see <a
        /// href="https://docs.stripe.com/connect/pausing-payments-or-payouts-on-connected-accounts">this
        /// page for more details</a>.
        /// </summary>
        [JsonProperty("charges")]
        [STJS.JsonPropertyName("charges")]
        public AccountRiskControlsChargesOptions Charges { get; set; }

        /// <summary>
        /// Represents the risk control status of payouts. Please see <a
        /// href="https://docs.stripe.com/connect/pausing-payments-or-payouts-on-connected-accounts">this
        /// page for more details</a>.
        /// </summary>
        [JsonProperty("payouts")]
        [STJS.JsonPropertyName("payouts")]
        public AccountRiskControlsPayoutsOptions Payouts { get; set; }
    }
}
