using Newtonsoft.Json;

namespace Stripe
{
    public class StripeTransferSummary
    {
        /// <summary>
        /// Count of adjustments
        /// </summary>
        [JsonProperty("adjustment_count")]
        public int? AdjustmentCount { get; set; }

        /// <summary>
        /// Total of adjustments applied to account, in cents.
        /// </summary>
        [JsonProperty("adjustment_gross")]
        public int? AdjustmentAmountInCents { get; set; }

        /// <summary>
        /// Count of successful charges
        /// </summary>
        [JsonProperty("charge_count")]
        public int? ChargeCount { get; set; }

        /// <summary>
        /// Total fees, in cents
        /// </summary>
        [JsonProperty("charge_fees")]
        public int? ChargeFeesInCents { get; set; }

        /// <summary>
        /// Total amount successfully charged to customers, in cents.
        /// </summary>
        [JsonProperty("charge_gross")]
        public int? ChargeAmountInCents { get; set; }

        /// <summary>
        /// Net transfer, in cents
        /// </summary>
        [JsonProperty("net")]
        public int? NetAmountInCents { get; set; }

        /// <summary>
        /// Count of refunds issued
        /// </summary>
        [JsonProperty("refund_count")]
        public int? RefundCount { get; set; }

        /// <summary>
        /// Total fee amount for refunds, in cents
        /// </summary>
        [JsonProperty("refund_fees")]
        public int? RefundFeesInCents { get; set; }

        /// <summary>
        /// Total amount of refunds issued, in cents
        /// </summary>
        [JsonProperty("refund_gross")]
        public int? RefundAmountInCents { get; set; }

        [JsonProperty("validation_count")]
        public int? ValidationCount { get; set; }

        [JsonProperty("validation_fees")]
        public int? ValidationFeeAmountInCents { get; set; }
    }
}
