// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionInvoiceCreationOptions : INestedOptions
    {
        /// <summary>
        /// Set to <c>true</c> to enable invoice creation.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Parameters passed when creating invoices for payment-mode Checkout Sessions.
        /// </summary>
        [JsonProperty("invoice_data")]
        [STJS.JsonPropertyName("invoice_data")]
        public SessionInvoiceCreationInvoiceDataOptions InvoiceData { get; set; }
    }
}
