using Newtonsoft.Json;

namespace Stripe
{
    public class StripeChargeListOptions : StripeListOptions
    {
        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }

        [JsonProperty("customer")]
        public string CustomerId { get; set; }
    }
}
