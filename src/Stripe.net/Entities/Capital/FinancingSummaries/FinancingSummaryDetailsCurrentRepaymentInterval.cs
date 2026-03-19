// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancingSummaryDetailsCurrentRepaymentInterval : StripeEntity<FinancingSummaryDetailsCurrentRepaymentInterval>
    {
        /// <summary>
        /// The time at which the minimum payment amount will be due. If not met through
        /// withholding, the Connected account's linked bank account or account balance will be
        /// debited. Given in seconds since unix epoch.
        /// </summary>
        [JsonProperty("due_at")]
        [STJS.JsonPropertyName("due_at")]
        public decimal DueAt { get; set; }

        /// <summary>
        /// The amount that has already been paid in the current repayment interval, in minor units.
        /// For example, 100 USD is represented as 10000.
        /// </summary>
        [JsonProperty("paid_amount")]
        [STJS.JsonPropertyName("paid_amount")]
        public long? PaidAmount { get; set; }

        /// <summary>
        /// The amount that is yet to be paid in the current repayment interval, in minor units. For
        /// example, 100 USD is represented as 10000.
        /// </summary>
        [JsonProperty("remaining_amount")]
        [STJS.JsonPropertyName("remaining_amount")]
        public long RemainingAmount { get; set; }
    }
}
