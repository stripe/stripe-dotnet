// File generated from our OpenAPI spec
namespace Stripe.ProductCatalog
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TrialOfferEndBehavior : StripeEntity<TrialOfferEndBehavior>
    {
        [JsonProperty("transition")]
        [STJS.JsonPropertyName("transition")]
        public TrialOfferEndBehaviorTransition Transition { get; set; }

        /// <summary>
        /// The type of behavior when the trial offer ends.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
