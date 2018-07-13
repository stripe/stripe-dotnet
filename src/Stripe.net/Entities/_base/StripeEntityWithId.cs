namespace Stripe
{
    using Newtonsoft.Json;

    public abstract class StripeEntityWithId : StripeEntity
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}