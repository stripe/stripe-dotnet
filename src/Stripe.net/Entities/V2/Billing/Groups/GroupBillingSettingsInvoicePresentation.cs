// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GroupBillingSettingsInvoicePresentation : StripeEntity<GroupBillingSettingsInvoicePresentation>
    {
        /// <summary>
        /// The ID of the invoice rendering template to be used when generating invoices.
        /// </summary>
        [JsonProperty("invoice_rendering_template")]
        [STJS.JsonPropertyName("invoice_rendering_template")]
        public string InvoiceRenderingTemplate { get; set; }
    }
}
