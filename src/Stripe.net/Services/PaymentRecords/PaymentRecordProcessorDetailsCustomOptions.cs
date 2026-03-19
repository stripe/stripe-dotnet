// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentRecordProcessorDetailsCustomOptions : INestedOptions
    {
        /// <summary>
        /// An opaque string for manual reconciliation of this payment, for example a check number
        /// or a payment processor ID.
        /// </summary>
        [JsonProperty("payment_reference")]
        [STJS.JsonPropertyName("payment_reference")]
        public string PaymentReference { get; set; }

        /// <summary>
        /// A reference to the external refund. This field must be unique across all refunds.
        /// </summary>
        [JsonProperty("refund_reference")]
        [STJS.JsonPropertyName("refund_reference")]
        public string RefundReference { get; set; }
    }
}
