// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RefundDestinationDetailsCard : StripeEntity<RefundDestinationDetailsCard>
    {
        /// <summary>
        /// Value of the reference number assigned to the refund.
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif
        public string Reference { get; set; }

        /// <summary>
        /// Status of the reference number on the refund. This can be <c>pending</c>,
        /// <c>available</c> or <c>unavailable</c>.
        /// </summary>
        [JsonProperty("reference_status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference_status")]
#endif
        public string ReferenceStatus { get; set; }

        /// <summary>
        /// Type of the reference number assigned to the refund.
        /// </summary>
        [JsonProperty("reference_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference_type")]
#endif
        public string ReferenceType { get; set; }

        /// <summary>
        /// The type of refund. This can be <c>refund</c>, <c>reversal</c>, or <c>pending</c>.
        /// One of: <c>pending</c>, <c>refund</c>, or <c>reversal</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
