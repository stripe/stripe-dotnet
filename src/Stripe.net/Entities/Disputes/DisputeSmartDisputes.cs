// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DisputeSmartDisputes : StripeEntity<DisputeSmartDisputes>
    {
        /// <summary>
        /// Evidence that could be provided to improve the SmartDisputes packet.
        /// </summary>
        [JsonProperty("recommended_evidence")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("recommended_evidence")]
#endif
        public List<List<string>> RecommendedEvidence { get; set; }

        /// <summary>
        /// Smart Disputes auto representment packet availability status.
        /// One of: <c>available</c>, <c>processing</c>, <c>requires_evidence</c>, or
        /// <c>unavailable</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
