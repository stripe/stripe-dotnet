// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionInvoiceCreationOptions : INestedOptions
    {
        /// <summary>
        /// Set to <c>true</c> to enable invoice creation.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif

        public bool? Enabled { get; set; }

        /// <summary>
        /// Parameters passed when creating invoices for payment-mode Checkout Sessions.
        /// </summary>
        [JsonProperty("invoice_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_data")]
#endif

        public SessionInvoiceCreationInvoiceDataOptions InvoiceData { get; set; }
    }
}
