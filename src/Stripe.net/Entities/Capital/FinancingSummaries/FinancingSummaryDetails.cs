// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancingSummaryDetails : StripeEntity<FinancingSummaryDetails>
    {
        /// <summary>
        /// Amount of financing offered, in minor units. For example, $1,000 USD will be represented
        /// as 100000.
        /// </summary>
        [JsonProperty("advance_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("advance_amount")]
#endif
        public long AdvanceAmount { get; set; }

        /// <summary>
        /// The time at which the funds were paid out to the connected account's Stripe balance.
        /// Given in milliseconds since unix epoch.
        /// </summary>
        [JsonProperty("advance_paid_out_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("advance_paid_out_at")]
#endif
        public decimal? AdvancePaidOutAt { get; set; }

        /// <summary>
        /// Currency that the financing offer is transacted in. For example, <c>usd</c>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// The chronologically current repayment interval for the financing offer.
        /// </summary>
        [JsonProperty("current_repayment_interval")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("current_repayment_interval")]
#endif
        public FinancingSummaryDetailsCurrentRepaymentInterval CurrentRepaymentInterval { get; set; }

        /// <summary>
        /// Fixed fee amount, in minor units. For example, $100 USD will be represented as 10000.
        /// </summary>
        [JsonProperty("fee_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fee_amount")]
#endif
        public long FeeAmount { get; set; }

        /// <summary>
        /// The amount the Connected account has paid toward the financing debt so far, in minor
        /// units. For example, $1,000 USD will be represented as 100000.
        /// </summary>
        [JsonProperty("paid_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paid_amount")]
#endif
        public long PaidAmount { get; set; }

        /// <summary>
        /// The balance remaining to be paid on the financing, in minor units. For example, $1,000
        /// USD will be represented as 100000.
        /// </summary>
        [JsonProperty("remaining_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("remaining_amount")]
#endif
        public long RemainingAmount { get; set; }

        /// <summary>
        /// The time at which Capital will begin withholding from payments. Given in seconds since
        /// unix epoch.
        /// </summary>
        [JsonProperty("repayments_begin_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("repayments_begin_at")]
#endif
        public decimal? RepaymentsBeginAt { get; set; }

        /// <summary>
        /// Per-transaction rate at which Stripe will withhold funds to repay the financing.
        /// </summary>
        [JsonProperty("withhold_rate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("withhold_rate")]
#endif
        public decimal WithholdRate { get; set; }
    }
}
