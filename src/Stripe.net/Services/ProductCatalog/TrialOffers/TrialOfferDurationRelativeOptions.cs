// File generated from our OpenAPI spec
namespace Stripe.ProductCatalog
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TrialOfferDurationRelativeOptions : INestedOptions
    {
        /// <summary>
        /// The number of recurring price's interval to apply for the trial period.
        /// </summary>
        [JsonProperty("iterations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("iterations")]
#endif
        public long? Iterations { get; set; }
    }
}
