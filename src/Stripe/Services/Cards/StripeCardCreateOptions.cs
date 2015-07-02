using Newtonsoft.Json;

namespace Stripe
{
    public class StripeCardCreateOptions
    {
        [JsonProperty("source")]
        public StripeSourceOptions Source { get; set; }
    }
}
