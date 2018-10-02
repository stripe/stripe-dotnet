namespace Stripe
{
    using Newtonsoft.Json;

    public abstract class StripeEntityWithId : StripeEntity, IStripeEntityWithId
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
