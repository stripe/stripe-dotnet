// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancingSummaryDetails : StripeEntity<FinancingSummaryDetails>
    {
        /// <summary>
        /// Amount of financing offered, in minor units. For example, 1,000 USD is represented as
        /// 100000.
        /// </summary>
        [JsonProperty("advance_amount")]
        [STJS.JsonPropertyName("advance_amount")]
        public long AdvanceAmount { get; set; }

        /// <summary>
        /// The time at which the funds were paid out to the connected account's Stripe balance.
        /// Given in milliseconds since unix epoch.
        /// </summary>
        [JsonProperty("advance_paid_out_at")]
        [STJS.JsonPropertyName("advance_paid_out_at")]
        public decimal? AdvancePaidOutAt { get; set; }

        /// <summary>
        /// Currency that the financing offer is transacted in. For example, <c>usd</c>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The chronologically current repayment interval for the financing offer.
        /// </summary>
        [JsonProperty("current_repayment_interval")]
        [STJS.JsonPropertyName("current_repayment_interval")]
        public FinancingSummaryDetailsCurrentRepaymentInterval CurrentRepaymentInterval { get; set; }

        /// <summary>
        /// Fixed fee amount, in minor units. For example, 100 USD is represented as 10000.
        /// </summary>
        [JsonProperty("fee_amount")]
        [STJS.JsonPropertyName("fee_amount")]
        public long FeeAmount { get; set; }

        /// <summary>
        /// The amount the Connected account has paid toward the financing debt so far, in minor
        /// units. For example, 1,000 USD is represented as 100000.
        /// </summary>
        [JsonProperty("paid_amount")]
        [STJS.JsonPropertyName("paid_amount")]
        public long PaidAmount { get; set; }

        /// <summary>
        /// The balance remaining to be paid on the financing, in minor units. For example, 1,000
        /// USD is represented as 100000.
        /// </summary>
        [JsonProperty("remaining_amount")]
        [STJS.JsonPropertyName("remaining_amount")]
        public long RemainingAmount { get; set; }

        /// <summary>
        /// The time at which Capital will begin withholding from payments. Given in seconds since
        /// unix epoch.
        /// </summary>
        [JsonProperty("repayments_begin_at")]
        [STJS.JsonPropertyName("repayments_begin_at")]
        public decimal? RepaymentsBeginAt { get; set; }

        /// <summary>
        /// Per-transaction rate at which Stripe withholds funds to repay the financing.
        /// </summary>
        [JsonProperty("withhold_rate")]
        [STJS.JsonPropertyName("withhold_rate")]
        public decimal WithholdRate { get; set; }
    }
}
