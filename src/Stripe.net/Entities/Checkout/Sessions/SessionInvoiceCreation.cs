// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionInvoiceCreation : StripeEntity<SessionInvoiceCreation>
    {
        /// <summary>
        /// Indicates whether invoice creation is enabled for the Checkout Session.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("invoice_data")]
        [STJS.JsonPropertyName("invoice_data")]
        public SessionInvoiceCreationInvoiceData InvoiceData { get; set; }
    }
}
