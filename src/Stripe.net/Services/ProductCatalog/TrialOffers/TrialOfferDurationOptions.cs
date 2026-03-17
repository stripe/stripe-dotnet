// File generated from our OpenAPI spec
namespace Stripe.ProductCatalog
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TrialOfferDurationOptions : INestedOptions
    {
        /// <summary>
        /// The relative duration of the trial period computed as the number of recurring price
        /// intervals.
        /// </summary>
        [JsonProperty("relative")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("relative")]
#endif
        public TrialOfferDurationRelativeOptions Relative { get; set; }

        /// <summary>
        /// Specifies how the trial offer duration is determined.
        /// One of: <c>relative</c>, or <c>timestamp</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
