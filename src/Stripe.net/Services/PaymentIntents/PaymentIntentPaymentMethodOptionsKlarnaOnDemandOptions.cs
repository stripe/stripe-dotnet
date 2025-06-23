// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodOptionsKlarnaOnDemandOptions : INestedOptions
    {
        /// <summary>
        /// Your average amount value. You can use a value across your customer base, or segment
        /// based on customer type, country, etc.
        /// </summary>
        [JsonProperty("average_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("average_amount")]
#endif
        public long? AverageAmount { get; set; }

        /// <summary>
        /// The maximum value you may charge a customer per purchase. You can use a value across
        /// your customer base, or segment based on customer type, country, etc.
        /// </summary>
        [JsonProperty("maximum_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("maximum_amount")]
#endif
        public long? MaximumAmount { get; set; }

        /// <summary>
        /// The lowest or minimum value you may charge a customer per purchase. You can use a value
        /// across your customer base, or segment based on customer type, country, etc.
        /// </summary>
        [JsonProperty("minimum_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("minimum_amount")]
#endif
        public long? MinimumAmount { get; set; }

        /// <summary>
        /// Interval at which the customer is making purchases.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("purchase_interval")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("purchase_interval")]
#endif
        public string PurchaseInterval { get; set; }

        /// <summary>
        /// The number of <c>purchase_interval</c> between charges.
        /// </summary>
        [JsonProperty("purchase_interval_count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("purchase_interval_count")]
#endif
        public long? PurchaseIntervalCount { get; set; }
    }
}
