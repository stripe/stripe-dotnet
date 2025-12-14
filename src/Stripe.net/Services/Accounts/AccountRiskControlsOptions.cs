// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountRiskControlsOptions : INestedOptions
    {
        /// <summary>
        /// Represents the risk control status of charges. Please see <a
        /// href="https://docs.stripe.com/connect/pausing-payments-or-payouts-on-connected-accounts">this
        /// page for more details</a>.
        /// </summary>
        [JsonProperty("charges")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charges")]
#endif
        public AccountRiskControlsChargesOptions Charges { get; set; }

        /// <summary>
        /// Represents the risk control status of payouts. Please see <a
        /// href="https://docs.stripe.com/connect/pausing-payments-or-payouts-on-connected-accounts">this
        /// page for more details</a>.
        /// </summary>
        [JsonProperty("payouts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payouts")]
#endif
        public AccountRiskControlsPayoutsOptions Payouts { get; set; }
    }
}
