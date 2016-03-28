using Newtonsoft.Json;

namespace Stripe
{
    public class StripeDisputeListOptions : StripeListOptions
    {
        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }
    }
}