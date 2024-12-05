// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionInvoiceCreation : StripeEntity<SessionInvoiceCreation>
    {
        /// <summary>
        /// Indicates whether invoice creation is enabled for the Checkout Session.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("invoice_data")]
        public SessionInvoiceCreationInvoiceData InvoiceData { get; set; }
    }
}
