using Newtonsoft.Json;

namespace Stripe
{
    public class StripeSubscriptionUpdateOptions : StripeSubscriptionCreateOptions
    {
        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }
    }
}