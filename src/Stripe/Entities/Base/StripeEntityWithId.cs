using Newtonsoft.Json;

namespace Stripe
{
    public abstract class StripeEntityWithId : StripeEntity
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}