// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentInvoiceResources : StripeEntity<IntentInvoiceResources>
    {
        /// <summary>
        /// ID of a preview invoice showing the breakdown of line items. Null if the billing intent
        /// will not create an invoice. Only present when "invoice_resources.preview_invoice" is
        /// included.
        /// </summary>
        [JsonProperty("preview_invoice")]
        [STJS.JsonPropertyName("preview_invoice")]
        public string PreviewInvoice { get; set; }
    }
}
