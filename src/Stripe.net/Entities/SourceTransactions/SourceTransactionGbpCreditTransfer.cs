// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceTransactionGbpCreditTransfer : StripeEntity<SourceTransactionGbpCreditTransfer>
    {
        /// <summary>
        /// Bank account fingerprint associated with the Stripe owned bank account receiving the
        /// transfer.
        /// </summary>
        [JsonProperty("fingerprint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fingerprint")]
#endif
        public string Fingerprint { get; set; }

        /// <summary>
        /// The credit transfer rails the sender used to push this transfer. The possible rails are:
        /// Faster Payments, BACS, CHAPS, and wire transfers. Currently only Faster Payments is
        /// supported.
        /// </summary>
        [JsonProperty("funding_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("funding_method")]
#endif
        public string FundingMethod { get; set; }

        /// <summary>
        /// Last 4 digits of sender account number associated with the transfer.
        /// </summary>
        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif
        public string Last4 { get; set; }

        /// <summary>
        /// Sender entered arbitrary information about the transfer.
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif
        public string Reference { get; set; }

        /// <summary>
        /// Sender account number associated with the transfer.
        /// </summary>
        [JsonProperty("sender_account_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sender_account_number")]
#endif
        public string SenderAccountNumber { get; set; }

        /// <summary>
        /// Sender name associated with the transfer.
        /// </summary>
        [JsonProperty("sender_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sender_name")]
#endif
        public string SenderName { get; set; }

        /// <summary>
        /// Sender sort code associated with the transfer.
        /// </summary>
        [JsonProperty("sender_sort_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sender_sort_code")]
#endif
        public string SenderSortCode { get; set; }
    }
}
