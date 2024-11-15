// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkInvoiceCreation : StripeEntity<PaymentLinkInvoiceCreation>
    {
        /// <summary>
        /// Enable creating an invoice on successful payment.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif

        public bool Enabled { get; set; }

        /// <summary>
        /// Configuration for the invoice. Default invoice values will be used if unspecified.
        /// </summary>
        [JsonProperty("invoice_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_data")]
#endif

        public PaymentLinkInvoiceCreationInvoiceData InvoiceData { get; set; }
    }
}
