// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceTransactionSepaCreditTransfer : StripeEntity<SourceTransactionSepaCreditTransfer>
    {
        /// <summary>
        /// Reference associated with the transfer.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

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
