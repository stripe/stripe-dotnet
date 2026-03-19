// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SourceTransactionSepaCreditTransfer : StripeEntity<SourceTransactionSepaCreditTransfer>
    {
        /// <summary>
        /// Reference associated with the transfer.
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Sender's bank account IBAN.
        /// </summary>
        [JsonProperty("sender_iban")]
        [STJS.JsonPropertyName("sender_iban")]
        public string SenderIban { get; set; }

        /// <summary>
        /// Sender's name.
        /// </summary>
        [JsonProperty("sender_name")]
        [STJS.JsonPropertyName("sender_name")]
        public string SenderName { get; set; }
    }
}
