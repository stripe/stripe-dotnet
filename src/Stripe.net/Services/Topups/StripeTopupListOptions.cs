using Newtonsoft.Json;

namespace Stripe
{
    public class StripeTopupListOptions : StripeListOptions
    {
        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }
    }
}
