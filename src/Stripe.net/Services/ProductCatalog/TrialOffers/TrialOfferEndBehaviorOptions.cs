// File generated from our OpenAPI spec
namespace Stripe.ProductCatalog
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TrialOfferEndBehaviorOptions : INestedOptions
    {
        /// <summary>
        /// The transition to apply when the trial offer ends.
        /// </summary>
        [JsonProperty("transition")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transition")]
#endif
        public TrialOfferEndBehaviorTransitionOptions Transition { get; set; }
    }
}
