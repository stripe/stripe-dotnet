// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceTransactionChfCreditTransfer : StripeEntity<SourceTransactionChfCreditTransfer>
    {
        /// <summary>
        /// Reference associated with the transfer.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Sender's country address.
        /// </summary>
        [JsonProperty("sender_address_country")]
        public string SenderAddressCountry { get; set; }

        /// <summary>
        /// Sender's line 1 address.
        /// </summary>
        [JsonProperty("sender_address_line1")]
        public string SenderAddressLine1 { get; set; }

        /// <summary>
        /// Sender's bank account IBAN.
        /// </summary>
        [JsonProperty("sender_iban")]
        public string SenderIban { get; set; }

        /// <summary>
        /// Sender's name.
        /// </summary>
        [JsonProperty("sender_name")]
        public string SenderName { get; set; }
    }
}
