namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class DisputeListOptions : ListOptions
    {
        [JsonProperty("created")]
        public DateFilter Created { get; set; }

        [JsonProperty("transaction")]
        public string TransactionId { get; set; }
    }
}
