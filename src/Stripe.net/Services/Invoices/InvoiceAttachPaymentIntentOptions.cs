// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceAttachPaymentIntentOptions : BaseOptions
    {
        /// <summary>
        /// The portion of the PaymentIntent’s <c>amount</c> that should be applied to thisinvoice.
        /// Defaults to the entire amount.
        /// </summary>
        [JsonProperty("amount_requested")]
        public long? AmountRequested { get; set; }

        /// <summary>
        /// The ID of the PaymentIntent to attach to the invoice.
        /// </summary>
        [JsonProperty("payment_intent")]
        public string PaymentIntent { get; set; }
    }
}
