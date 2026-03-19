// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsKlarnaOnDemandOptions : INestedOptions
    {
        /// <summary>
        /// Your average amount value. You can use a value across your customer base, or segment
        /// based on customer type, country, etc.
        /// </summary>
        [JsonProperty("average_amount")]
        [STJS.JsonPropertyName("average_amount")]
        public long? AverageAmount { get; set; }

        /// <summary>
        /// The maximum value you may charge a customer per purchase. You can use a value across
        /// your customer base, or segment based on customer type, country, etc.
        /// </summary>
        [JsonProperty("maximum_amount")]
        [STJS.JsonPropertyName("maximum_amount")]
        public long? MaximumAmount { get; set; }

        /// <summary>
        /// The lowest or minimum value you may charge a customer per purchase. You can use a value
        /// across your customer base, or segment based on customer type, country, etc.
        /// </summary>
        [JsonProperty("minimum_amount")]
        [STJS.JsonPropertyName("minimum_amount")]
        public long? MinimumAmount { get; set; }

        /// <summary>
        /// Interval at which the customer is making purchases.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("purchase_interval")]
        [STJS.JsonPropertyName("purchase_interval")]
        public string PurchaseInterval { get; set; }

        /// <summary>
        /// The number of <c>purchase_interval</c> between charges.
        /// </summary>
        [JsonProperty("purchase_interval_count")]
        [STJS.JsonPropertyName("purchase_interval_count")]
        public long? PurchaseIntervalCount { get; set; }
    }
}
