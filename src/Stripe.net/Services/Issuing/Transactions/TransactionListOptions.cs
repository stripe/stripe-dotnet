namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class TransactionListOptions : StripeListOptions
    {
        [JsonProperty("cardholder")]
        public string CardholderId { get; set; }

        [JsonProperty("card")]
        public string CardId { get; set; }

        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }
    }
}
