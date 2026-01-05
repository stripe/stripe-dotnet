// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TaxCodeRequirements : StripeEntity<TaxCodeRequirements>
    {
        /// <summary>
        /// Describes whether a performance location is required for a successful tax calculation
        /// with a tax code.
        /// One of: <c>optional</c>, or <c>required</c>.
        /// </summary>
        [JsonProperty("performance_location")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("performance_location")]
#endif
        public string PerformanceLocation { get; set; }
    }
}
