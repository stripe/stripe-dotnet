// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceAttachPaymentOptions : BaseOptions
    {
        /// <summary>
        /// The portion of the <c>amount</c> on the PaymentIntent or out of band payment to apply to
        /// this invoice. It defaults to the entire amount.
        /// </summary>
        [JsonProperty("amount_requested")]
        public long? AmountRequested { get; set; }

        /// <summary>
        /// The out of band payment to attach to the invoice.
        /// </summary>
        [JsonProperty("out_of_band_payment")]
        public InvoiceOutOfBandPaymentOptions OutOfBandPayment { get; set; }

        /// <summary>
        /// The ID of the PaymentIntent to attach to the invoice.
        /// </summary>
        [JsonProperty("payment_intent")]
        public string PaymentIntent { get; set; }
    }
}
