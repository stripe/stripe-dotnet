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
        /// The portion of the <c>amount</c> on the PaymentIntent or out of band payment to apply to
        /// this invoice. It defaults to the entire amount.
        /// </summary>
        [JsonProperty("amount_requested")]
        [STJS.JsonPropertyName("amount_requested")]
        public long? AmountRequested { get; set; }

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

        /// <summary>
        /// The PaymentRecord data for attaching an out of band payment to the invoice.
        /// </summary>
        [JsonProperty("payment_record_data")]
        [STJS.JsonPropertyName("payment_record_data")]
        public InvoicePaymentRecordDataOptions PaymentRecordData { get; set; }
    }
}
