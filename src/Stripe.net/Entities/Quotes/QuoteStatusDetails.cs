// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuoteStatusDetails : StripeEntity<QuoteStatusDetails>
    {
        [JsonProperty("canceled")]
        [STJS.JsonPropertyName("canceled")]
        public QuoteStatusDetailsCanceled Canceled { get; set; }

        [JsonProperty("stale")]
        [STJS.JsonPropertyName("stale")]
        public QuoteStatusDetailsStale Stale { get; set; }
    }
}
