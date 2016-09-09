using Newtonsoft.Json;

namespace Stripe
{
    public class StripeDeleted : StripeObject
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }
    }
}