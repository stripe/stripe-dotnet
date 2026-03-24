// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DisputeSmartDisputes : StripeEntity<DisputeSmartDisputes>
    {
        /// <summary>
        /// Evidence that could be provided to improve the SmartDisputes packet.
        /// </summary>
        [JsonProperty("recommended_evidence")]
        [STJS.JsonPropertyName("recommended_evidence")]
        public List<List<string>> RecommendedEvidence { get; set; }

        /// <summary>
        /// Smart Disputes auto representment packet availability status.
        /// One of: <c>available</c>, <c>processing</c>, <c>requires_evidence</c>, or
        /// <c>unavailable</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
