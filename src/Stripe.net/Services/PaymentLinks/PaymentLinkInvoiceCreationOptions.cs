// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkInvoiceCreationOptions : INestedOptions
    {
        /// <summary>
        /// Whether the feature is enabled.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif

        public bool? Enabled { get; set; }

        /// <summary>
        /// Invoice PDF configuration.
        /// </summary>
        [JsonProperty("invoice_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_data")]
#endif

        public PaymentLinkInvoiceCreationInvoiceDataOptions InvoiceData { get; set; }
    }
}
