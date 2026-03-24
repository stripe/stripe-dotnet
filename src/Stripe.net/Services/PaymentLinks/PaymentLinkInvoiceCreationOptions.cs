// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentLinkInvoiceCreationOptions : INestedOptions
    {
        /// <summary>
        /// Whether the feature is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Invoice PDF configuration.
        /// </summary>
        [JsonProperty("invoice_data")]
        [STJS.JsonPropertyName("invoice_data")]
        public PaymentLinkInvoiceCreationInvoiceDataOptions InvoiceData { get; set; }
    }
}
