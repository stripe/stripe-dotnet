// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RefundDestinationDetailsBrBankTransfer : StripeEntity<RefundDestinationDetailsBrBankTransfer>
    {
        /// <summary>
        /// The reference assigned to the refund.
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Status of the reference on the refund. This can be <c>pending</c>, <c>available</c> or
        /// <c>unavailable</c>.
        /// </summary>
        [JsonProperty("reference_status")]
        [STJS.JsonPropertyName("reference_status")]
        public string ReferenceStatus { get; set; }
    }
}
