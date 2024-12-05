// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class RefundDestinationDetailsCard : StripeEntity<RefundDestinationDetailsCard>
    {
        /// <summary>
        /// Value of the reference number assigned to the refund.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Status of the reference number on the refund. This can be <c>pending</c>,
        /// <c>available</c> or <c>unavailable</c>.
        /// </summary>
        [JsonProperty("reference_status")]
        public string ReferenceStatus { get; set; }

        /// <summary>
        /// Type of the reference number assigned to the refund.
        /// </summary>
        [JsonProperty("reference_type")]
        public string ReferenceType { get; set; }

        /// <summary>
        /// The type of refund. This can be <c>refund</c>, <c>reversal</c>, or <c>pending</c>.
        /// One of: <c>pending</c>, <c>refund</c>, or <c>reversal</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
