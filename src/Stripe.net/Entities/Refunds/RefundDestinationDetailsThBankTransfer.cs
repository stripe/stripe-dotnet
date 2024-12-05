// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class RefundDestinationDetailsThBankTransfer : StripeEntity<RefundDestinationDetailsThBankTransfer>
    {
        /// <summary>
        /// The reference assigned to the refund.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Status of the reference on the refund. This can be <c>pending</c>, <c>available</c> or
        /// <c>unavailable</c>.
        /// </summary>
        [JsonProperty("reference_status")]
        public string ReferenceStatus { get; set; }
    }
}
