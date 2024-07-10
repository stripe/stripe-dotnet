// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class FinancingSummaryDetailsCurrentRepaymentInterval : StripeEntity<FinancingSummaryDetailsCurrentRepaymentInterval>
    {
        /// <summary>
        /// The time at which the minimum payment amount will be due. If not met through
        /// withholding, the Connected account's linked bank account or account balance will be
        /// debited. Given in seconds since unix epoch.
        /// </summary>
        [JsonProperty("due_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime DueAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The amount that has already been paid in the current repayment interval.
        /// </summary>
        [JsonProperty("paid_amount")]
        public long? PaidAmount { get; set; }

        /// <summary>
        /// The amount that is yet to be paid in the current repayment interval.
        /// </summary>
        [JsonProperty("remaining_amount")]
        public long RemainingAmount { get; set; }
    }
}
