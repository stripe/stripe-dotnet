// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceTransactionAchCreditTransfer : StripeEntity<SourceTransactionAchCreditTransfer>
    {
        /// <summary>
        /// Customer data associated with the transfer.
        /// </summary>
        [JsonProperty("customer_data")]
        public string CustomerData { get; set; }

        /// <summary>
        /// Bank account fingerprint associated with the transfer.
        /// </summary>
        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Last 4 digits of the account number associated with the transfer.
        /// </summary>
        [JsonProperty("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// Routing number associated with the transfer.
        /// </summary>
        [JsonProperty("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
