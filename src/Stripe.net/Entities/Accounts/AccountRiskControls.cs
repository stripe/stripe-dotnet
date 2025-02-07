// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountRiskControls : StripeEntity<AccountRiskControls>
    {
        [JsonProperty("charges")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charges")]
#endif
        public AccountRiskControlsCharges Charges { get; set; }

        [JsonProperty("payouts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payouts")]
#endif
        public AccountRiskControlsPayouts Payouts { get; set; }

        /// <summary>
        /// Represents the rejected reason of the account. Empty if account is not rejected, or
        /// rejected by Stripe. Please see <a href="https://stripe.com/docs/connect/">this page for
        /// more details</a>.
        /// One of: <c>credit</c>, <c>fraud</c>, <c>fraud_no_intent_to_fulfill</c>,
        /// <c>fraud_other</c>, <c>fraud_payment_method_casher</c>,
        /// <c>fraud_payment_method_tester</c>, <c>other</c>, or <c>terms_of_service</c>.
        /// </summary>
        [JsonProperty("rejected_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rejected_reason")]
#endif
        public string RejectedReason { get; set; }
    }
}
