using Newtonsoft.Json;

namespace Stripe
{
    public class StripeCustomerListOptions : StripeListOptions
    {
        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }
    }
}