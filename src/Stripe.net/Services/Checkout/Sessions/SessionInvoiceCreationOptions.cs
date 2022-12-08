// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionInvoiceCreationOptions : INestedOptions
    {
        /// <summary>
        /// Set to <c>true</c> to enable invoice creation.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Parameters passed when creating invoices for payment-mode Checkout Sessions.
        /// </summary>
        [JsonProperty("invoice_data")]
        public SessionInvoiceCreationInvoiceDataOptions InvoiceData { get; set; }
    }
}
