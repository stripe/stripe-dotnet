// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SourceTransactionGbpCreditTransfer : StripeEntity<SourceTransactionGbpCreditTransfer>
    {
        /// <summary>
        /// Bank account fingerprint associated with the Stripe owned bank account receiving the
        /// transfer.
        /// </summary>
        [JsonProperty("fingerprint")]
        [STJS.JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// The credit transfer rails the sender used to push this transfer. The possible rails are:
        /// Faster Payments, BACS, CHAPS, and wire transfers. Currently only Faster Payments is
        /// supported.
        /// </summary>
        [JsonProperty("funding_method")]
        [STJS.JsonPropertyName("funding_method")]
        public string FundingMethod { get; set; }

        /// <summary>
        /// Last 4 digits of sender account number associated with the transfer.
        /// </summary>
        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// Sender entered arbitrary information about the transfer.
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Sender account number associated with the transfer.
        /// </summary>
        [JsonProperty("sender_account_number")]
        [STJS.JsonPropertyName("sender_account_number")]
        public string SenderAccountNumber { get; set; }

        /// <summary>
        /// Sender name associated with the transfer.
        /// </summary>
        [JsonProperty("sender_name")]
        [STJS.JsonPropertyName("sender_name")]
        public string SenderName { get; set; }

        /// <summary>
        /// Sender sort code associated with the transfer.
        /// </summary>
        [JsonProperty("sender_sort_code")]
        [STJS.JsonPropertyName("sender_sort_code")]
        public string SenderSortCode { get; set; }
    }
}
