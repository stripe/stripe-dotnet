namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeThreeDSecure : StripeEntity
    {
        [JsonProperty("card")]
        public string CardId { get; set; }

        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("authenticated")]
        public bool Authenticated { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }
    }
}
