using Newtonsoft.Json;

namespace Stripe
{
    public class StripeDeleted : StripeEntityWithId
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }
    }
}