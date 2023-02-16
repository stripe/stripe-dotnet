// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteStatusDetails : StripeEntity<QuoteStatusDetails>
    {
        [JsonProperty("canceled")]
        public QuoteStatusDetailsCanceled Canceled { get; set; }

        [JsonProperty("stale")]
        public QuoteStatusDetailsStale Stale { get; set; }
    }
}
