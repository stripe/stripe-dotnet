// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceRendering : StripeEntity<InvoiceRendering>
    {
        /// <summary>
        /// Invoice pdf rendering options.
        /// </summary>
        [JsonProperty("pdf")]
        public InvoiceRenderingPdf Pdf { get; set; }
    }
}
