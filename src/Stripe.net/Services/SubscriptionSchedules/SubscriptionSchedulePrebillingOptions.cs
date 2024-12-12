// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionSchedulePrebillingOptions : INestedOptions
    {
        /// <summary>
        /// The beginning of the prebilled time period. The default value is <c>now</c>.
        /// </summary>
        [JsonProperty("bill_from")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bill_from")]
#endif
        public SubscriptionSchedulePrebillingBillFromOptions BillFrom { get; set; }

        /// <summary>
        /// The end of the prebilled time period.
        /// </summary>
        [JsonProperty("bill_until")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bill_until")]
#endif
        public SubscriptionSchedulePrebillingBillUntilOptions BillUntil { get; set; }

        /// <summary>
        /// When the prebilling invoice should be created. The default value is <c>now</c>.
        /// </summary>
        [JsonProperty("invoice_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_at")]
#endif
        public string InvoiceAt { get; set; }

        /// <summary>
        /// This is used to determine the number of billing cycles to prebill.
        /// </summary>
        [JsonProperty("iterations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("iterations")]
#endif
        public long? Iterations { get; set; }

        /// <summary>
        /// Whether to cancel or preserve <c>prebilling</c> if the subscription is updated during
        /// the prebilled period. The default value is <c>reset</c>.
        /// One of: <c>prebill</c>, or <c>reset</c>.
        /// </summary>
        [JsonProperty("update_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("update_behavior")]
#endif
        public string UpdateBehavior { get; set; }
    }
}
