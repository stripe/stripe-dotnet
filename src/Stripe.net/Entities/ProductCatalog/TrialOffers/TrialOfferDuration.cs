// File generated from our OpenAPI spec
namespace Stripe.ProductCatalog
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TrialOfferDuration : StripeEntity<TrialOfferDuration>
    {
        [JsonProperty("relative")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("relative")]
#endif
        public TrialOfferDurationRelative Relative { get; set; }

        /// <summary>
        /// The type of trial offer duration.
        /// One of: <c>relative</c>, or <c>timestamp</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
