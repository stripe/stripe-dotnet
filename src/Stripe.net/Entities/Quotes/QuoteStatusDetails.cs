// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteStatusDetails : StripeEntity<QuoteStatusDetails>
    {
        /// <summary>
        /// Details on when and why a quote has been marked as canceled.
        /// </summary>
        [JsonProperty("canceled")]
        public QuoteStatusDetailsCanceled Canceled { get; set; }

        /// <summary>
        /// Details on when and why a quote has been marked as stale.
        /// </summary>
        [JsonProperty("stale")]
        public QuoteStatusDetailsStale Stale { get; set; }
    }
}
