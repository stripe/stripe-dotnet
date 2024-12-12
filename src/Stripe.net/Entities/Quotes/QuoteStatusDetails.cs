// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteStatusDetails : StripeEntity<QuoteStatusDetails>
    {
        [JsonProperty("canceled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("canceled")]
#endif
        public QuoteStatusDetailsCanceled Canceled { get; set; }

        [JsonProperty("stale")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("stale")]
#endif
        public QuoteStatusDetailsStale Stale { get; set; }
    }
}
