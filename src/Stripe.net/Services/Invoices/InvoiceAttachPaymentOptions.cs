// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceAttachPaymentOptions : BaseOptions
    {
        /// <summary>
        /// The ID of the PaymentIntent to attach to the invoice.
        /// </summary>
        [JsonProperty("payment_intent")]
        [STJS.JsonPropertyName("payment_intent")]
        public string PaymentIntent { get; set; }

        /// <summary>
        /// The ID of the PaymentRecord to attach to the invoice.
        /// </summary>
        [JsonProperty("payment_record")]
        [STJS.JsonPropertyName("payment_record")]
        public string PaymentRecord { get; set; }
    }
}
