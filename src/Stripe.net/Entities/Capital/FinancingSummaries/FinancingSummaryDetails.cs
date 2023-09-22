// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class FinancingSummaryDetails : StripeEntity<FinancingSummaryDetails>
    {
        /// <summary>
        /// Amount of financing offered, in minor units.
        /// </summary>
        [JsonProperty("advance_amount")]
        public long AdvanceAmount { get; set; }

        /// <summary>
        /// The time at which the funds were paid out the the Connected account's Stripe balance.
        /// Given in milliseconds since unix epoch.
        /// </summary>
        [JsonProperty("advance_paid_out_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? AdvancePaidOutAt { get; set; }

        /// <summary>
        /// Currency that the financing offer is transacted in. For example, <c>usd</c>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The chronologically current repayment interval for the financing offer.
        /// </summary>
        [JsonProperty("current_repayment_interval")]
        public FinancingSummaryDetailsCurrentRepaymentInterval CurrentRepaymentInterval { get; set; }

        /// <summary>
        /// Fixed fee amount, in minor units.
        /// </summary>
        [JsonProperty("fee_amount")]
        public long FeeAmount { get; set; }

        /// <summary>
        /// The amount the Connected account has paid toward the financing debt so far.
        /// </summary>
        [JsonProperty("paid_amount")]
        public long PaidAmount { get; set; }

        /// <summary>
        /// The balance remaining to be paid on the financing, in minor units.
        /// </summary>
        [JsonProperty("remaining_amount")]
        public long RemainingAmount { get; set; }

        /// <summary>
        /// The time at which Capital will begin withholding from payments. Given in seconds since
        /// unix epoch.
        /// </summary>
        [JsonProperty("repayments_begin_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? RepaymentsBeginAt { get; set; }

        /// <summary>
        /// Per-transaction rate at which Stripe will withhold funds to repay the financing.
        /// </summary>
        [JsonProperty("withhold_rate")]
        public decimal WithholdRate { get; set; }
    }
}
