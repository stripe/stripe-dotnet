// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceTransactionAchCreditTransfer : StripeEntity<SourceTransactionAchCreditTransfer>
    {
        /// <summary>
        /// Customer data associated with the transfer.
        /// </summary>
        [JsonProperty("customer_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_data")]
#endif
        public string CustomerData { get; set; }

        /// <summary>
        /// Bank account fingerprint associated with the transfer.
        /// </summary>
        [JsonProperty("fingerprint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fingerprint")]
#endif
        public string Fingerprint { get; set; }

        /// <summary>
        /// Last 4 digits of the account number associated with the transfer.
        /// </summary>
        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif
        public string Last4 { get; set; }

        /// <summary>
        /// Routing number associated with the transfer.
        /// </summary>
        [JsonProperty("routing_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("routing_number")]
#endif
        public string RoutingNumber { get; set; }
    }
}
