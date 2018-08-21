namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class TransactionListOptions : ListOptions
    {
        [JsonProperty("cardholder")]
        public string CardholderId { get; set; }

        [JsonProperty("card")]
        public string CardId { get; set; }

        [JsonProperty("created")]
        public DateFilter Created { get; set; }
    }
}
