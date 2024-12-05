// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkInvoiceCreation : StripeEntity<PaymentLinkInvoiceCreation>
    {
        /// <summary>
        /// Enable creating an invoice on successful payment.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Configuration for the invoice. Default invoice values will be used if unspecified.
        /// </summary>
        [JsonProperty("invoice_data")]
        public PaymentLinkInvoiceCreationInvoiceData InvoiceData { get; set; }
    }
}
