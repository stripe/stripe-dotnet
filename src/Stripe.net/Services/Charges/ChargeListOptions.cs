namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargeListOptions : ListOptions
    {
        [JsonProperty("created")]
        public DateFilter Created { get; set; }

        [JsonProperty("customer")]
        public string CustomerId { get; set; }
    }
}
