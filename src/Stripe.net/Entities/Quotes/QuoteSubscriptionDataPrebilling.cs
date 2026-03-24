// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuoteSubscriptionDataPrebilling : StripeEntity<QuoteSubscriptionDataPrebilling>
    {
        [JsonProperty("iterations")]
        [STJS.JsonPropertyName("iterations")]
        public long Iterations { get; set; }
    }
}
