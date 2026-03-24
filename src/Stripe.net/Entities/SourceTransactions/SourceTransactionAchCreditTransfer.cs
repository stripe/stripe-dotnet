// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SourceTransactionAchCreditTransfer : StripeEntity<SourceTransactionAchCreditTransfer>
    {
        /// <summary>
        /// Customer data associated with the transfer.
        /// </summary>
        [JsonProperty("customer_data")]
        [STJS.JsonPropertyName("customer_data")]
        public string CustomerData { get; set; }

        /// <summary>
        /// Bank account fingerprint associated with the transfer.
        /// </summary>
        [JsonProperty("fingerprint")]
        [STJS.JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Last 4 digits of the account number associated with the transfer.
        /// </summary>
        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// Routing number associated with the transfer.
        /// </summary>
        [JsonProperty("routing_number")]
        [STJS.JsonPropertyName("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
