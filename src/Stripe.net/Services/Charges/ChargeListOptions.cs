namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargeListOptions : ListOptionsWithCreated
    {
        [JsonProperty("customer")]
        public string CustomerId { get; set; }
    }
}
