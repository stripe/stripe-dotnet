// File generated from our OpenAPI spec
namespace Stripe.ProductCatalog
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TrialOfferDurationRelative : StripeEntity<TrialOfferDurationRelative>
    {
        /// <summary>
        /// The number of iterations of the price's interval for this trial offer.
        /// </summary>
        [JsonProperty("iterations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("iterations")]
#endif
        public long Iterations { get; set; }
    }
}
