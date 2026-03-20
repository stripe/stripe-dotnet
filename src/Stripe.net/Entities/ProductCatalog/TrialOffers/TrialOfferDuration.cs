// File generated from our OpenAPI spec
namespace Stripe.ProductCatalog
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TrialOfferDuration : StripeEntity<TrialOfferDuration>
    {
        [JsonProperty("relative")]
        [STJS.JsonPropertyName("relative")]
        public TrialOfferDurationRelative Relative { get; set; }

        /// <summary>
        /// The type of trial offer duration.
        /// One of: <c>relative</c>, or <c>timestamp</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
