// File generated from our OpenAPI spec
namespace Stripe.ProductCatalog
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TrialOfferDurationOptions : INestedOptions
    {
        /// <summary>
        /// The relative duration of the trial period computed as the number of recurring price
        /// intervals.
        /// </summary>
        [JsonProperty("relative")]
        [STJS.JsonPropertyName("relative")]
        public TrialOfferDurationRelativeOptions Relative { get; set; }

        /// <summary>
        /// Specifies how the trial offer duration is determined.
        /// One of: <c>relative</c>, or <c>timestamp</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
