namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceTransactionSepaCreditTransfer : StripeEntity<SourceTransactionSepaCreditTransfer>
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("sender_iban")]
        public string SenderIban { get; set; }

        [JsonProperty("sender_name")]
        public string SenderName { get; set; }
    }
}
