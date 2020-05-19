namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ConnectionToken : StripeEntity<ConnectionToken>, IHasObject
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }
    }
}
