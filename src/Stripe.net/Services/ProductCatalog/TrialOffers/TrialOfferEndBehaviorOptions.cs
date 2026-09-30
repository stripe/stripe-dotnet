// File generated from our OpenAPI spec
namespace Stripe.ProductCatalog
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TrialOfferEndBehaviorOptions : INestedOptions
    {
        /// <summary>
        /// The transition to apply when the trial offer ends.
        /// </summary>
        [JsonProperty("transition")]
        [STJS.JsonPropertyName("transition")]
        public TrialOfferEndBehaviorTransitionOptions Transition { get; set; }
    }
}
