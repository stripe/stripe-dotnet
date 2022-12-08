// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionInvoiceCreationInvoiceDataRenderingOptions : StripeEntity<SessionInvoiceCreationInvoiceDataRenderingOptions>
    {
        /// <summary>
        /// How line-item prices and amounts will be displayed with respect to tax on invoice PDFs.
        /// </summary>
        [JsonProperty("amount_tax_display")]
        public string AmountTaxDisplay { get; set; }
    }
}
