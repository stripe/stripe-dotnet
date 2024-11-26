// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionInvoiceCreation : StripeEntity<SessionInvoiceCreation>
    {
        /// <summary>
        /// Indicates whether invoice creation is enabled for the Checkout Session.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool Enabled { get; set; }

        [JsonProperty("invoice_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_data")]
#endif
        public SessionInvoiceCreationInvoiceData InvoiceData { get; set; }
    }
}
