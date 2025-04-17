// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancingSummaryDetailsCurrentRepaymentInterval : StripeEntity<FinancingSummaryDetailsCurrentRepaymentInterval>
    {
        /// <summary>
        /// The time at which the minimum payment amount will be due. If not met through
        /// withholding, the Connected account's linked bank account or account balance will be
        /// debited. Given in seconds since unix epoch.
        /// </summary>
        [JsonProperty("due_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("due_at")]
#endif
        public decimal DueAt { get; set; }

        /// <summary>
        /// The amount that has already been paid in the current repayment interval, in minor units.
        /// For example, $100 USD will be represented as 10000.
        /// </summary>
        [JsonProperty("paid_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paid_amount")]
#endif
        public long? PaidAmount { get; set; }

        /// <summary>
        /// The amount that is yet to be paid in the current repayment interval, in minor units. For
        /// example, $100 USD will be represented as 10000.
        /// </summary>
        [JsonProperty("remaining_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("remaining_amount")]
#endif
        public long RemainingAmount { get; set; }
    }
}
