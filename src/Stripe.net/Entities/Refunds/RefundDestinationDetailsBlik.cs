// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RefundDestinationDetailsBlik : StripeEntity<RefundDestinationDetailsBlik>
    {
        /// <summary>
        /// For refunds declined by the network, a decline code provided by the network which
        /// indicates the reason the refund failed.
        /// </summary>
        [JsonProperty("network_decline_code")]
        public string NetworkDeclineCode { get; set; }

        /// <summary>
        /// The reference assigned to the refund.
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif
        public string Reference { get; set; }

        /// <summary>
        /// Status of the reference on the refund. This can be <c>pending</c>, <c>available</c> or
        /// <c>unavailable</c>.
        /// </summary>
        [JsonProperty("reference_status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference_status")]
#endif
        public string ReferenceStatus { get; set; }
    }
}
