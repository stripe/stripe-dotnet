// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoicePaymentPaymentOptions : INestedOptions
    {
        /// <summary>
        /// Only return invoice payments associated by this payment intent ID.
        /// </summary>
        [JsonProperty("payment_intent")]
        [STJS.JsonPropertyName("payment_intent")]
        public string PaymentIntent { get; set; }

        /// <summary>
        /// Only return invoice payments associated by this payment record ID.
        /// </summary>
        [JsonProperty("payment_record")]
        [STJS.JsonPropertyName("payment_record")]
        public string PaymentRecord { get; set; }

        /// <summary>
        /// Only return invoice payments associated by this payment type.
        /// One of: <c>payment_intent</c>, or <c>payment_record</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
