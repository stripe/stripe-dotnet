using Newtonsoft.Json;

namespace Stripe
{
    public class StripeEventListOptions : StripeListOptions
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }
    }
}