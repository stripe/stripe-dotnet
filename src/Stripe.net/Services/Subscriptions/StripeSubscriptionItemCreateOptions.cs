using Newtonsoft.Json;

namespace Stripe { 
    public class StripeSubscriptionItemCreateOptions : StripeSubscriptionItemBaseChangeOptions
    {
        [JsonProperty("quantity")]
        public int? Quantity { get; set; }
    }
}
