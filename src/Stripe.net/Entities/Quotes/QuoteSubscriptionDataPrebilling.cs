// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteSubscriptionDataPrebilling : StripeEntity<QuoteSubscriptionDataPrebilling>
    {
        [JsonProperty("iterations")]
        public long Iterations { get; set; }
    }
}
