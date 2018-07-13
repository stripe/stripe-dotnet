namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeApplication : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
     }
}
