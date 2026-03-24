// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionInvoiceCreationInvoiceDataRenderingOptions : StripeEntity<SessionInvoiceCreationInvoiceDataRenderingOptions>
    {
        /// <summary>
        /// How line-item prices and amounts will be displayed with respect to tax on invoice PDFs.
        /// </summary>
        [JsonProperty("amount_tax_display")]
        [STJS.JsonPropertyName("amount_tax_display")]
        public string AmountTaxDisplay { get; set; }

        /// <summary>
        /// ID of the invoice rendering template to be used for the generated invoice.
        /// </summary>
        [JsonProperty("template")]
        [STJS.JsonPropertyName("template")]
        public string Template { get; set; }
    }
}
