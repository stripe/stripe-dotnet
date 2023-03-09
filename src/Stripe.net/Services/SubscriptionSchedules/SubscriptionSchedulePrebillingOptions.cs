// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionSchedulePrebillingOptions : INestedOptions
    {
        /// <summary>
        /// The beginning of the prebilled time period. The default value is <c>now</c>.
        /// </summary>
        [JsonProperty("bill_from")]
        public SubscriptionSchedulePrebillingBillFromOptions BillFrom { get; set; }

        /// <summary>
        /// The end of the prebilled time period.
        /// </summary>
        [JsonProperty("bill_until")]
        public SubscriptionSchedulePrebillingBillUntilOptions BillUntil { get; set; }

        /// <summary>
        /// When the prebilling invoice should be created. The default value is <c>now</c>.
        /// </summary>
        [JsonProperty("invoice_at")]
        public string InvoiceAt { get; set; }

        /// <summary>
        /// This is used to determine the number of billing cycles to prebill.
        /// </summary>
        [JsonProperty("iterations")]
        public long? Iterations { get; set; }

        /// <summary>
        /// Whether to cancel or preserve <c>prebilling</c> if the subscription is updated during
        /// the prebilled period. The default value is <c>reset</c>.
        /// One of: <c>prebill</c>, or <c>reset</c>.
        /// </summary>
        [JsonProperty("update_behavior")]
        public string UpdateBehavior { get; set; }
    }
}
