namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomAccountKeys : StripeEntity
    {
        [JsonProperty("publishable")]
        public string Publishable { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }
    }
}
