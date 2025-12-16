// File generated from our OpenAPI spec
namespace Stripe.ProductCatalog
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TrialOfferEndBehavior : StripeEntity<TrialOfferEndBehavior>
    {
        [JsonProperty("transition")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transition")]
#endif
        public TrialOfferEndBehaviorTransition Transition { get; set; }

        /// <summary>
        /// The type of behavior when the trial offer ends.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
