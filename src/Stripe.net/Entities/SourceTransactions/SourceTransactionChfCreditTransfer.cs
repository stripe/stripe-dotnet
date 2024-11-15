// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceTransactionChfCreditTransfer : StripeEntity<SourceTransactionChfCreditTransfer>
    {
        /// <summary>
        /// Reference associated with the transfer.
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif

        public string Reference { get; set; }

        /// <summary>
        /// Sender's country address.
        /// </summary>
        [JsonProperty("sender_address_country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sender_address_country")]
#endif

        public string SenderAddressCountry { get; set; }

        /// <summary>
        /// Sender's line 1 address.
        /// </summary>
        [JsonProperty("sender_address_line1")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sender_address_line1")]
#endif

        public string SenderAddressLine1 { get; set; }

        /// <summary>
        /// Sender's bank account IBAN.
        /// </summary>
        [JsonProperty("sender_iban")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sender_iban")]
#endif

        public string SenderIban { get; set; }

        /// <summary>
        /// Sender's name.
        /// </summary>
        [JsonProperty("sender_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sender_name")]
#endif

        public string SenderName { get; set; }
    }
}
