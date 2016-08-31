using Newtonsoft.Json;

namespace Stripe
{
    public abstract class StripeObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}