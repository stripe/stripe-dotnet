namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargeListOptions : ListOptionsWithCreated
    {
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("source")]
        public ChargeSourceListOptions Source { get; set; }
    }
}
