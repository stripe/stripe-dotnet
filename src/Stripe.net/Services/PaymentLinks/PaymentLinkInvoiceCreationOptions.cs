// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkInvoiceCreationOptions : INestedOptions
    {
        /// <summary>
        /// Whether the feature is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Invoice PDF configuration.
        /// </summary>
        [JsonProperty("invoice_data")]
        public PaymentLinkInvoiceCreationInvoiceDataOptions InvoiceData { get; set; }
    }
}
