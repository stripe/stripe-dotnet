// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceRenderingOptions : INestedOptions
    {
        /// <summary>
        /// Invoice pdf rendering options.
        /// </summary>
        [JsonProperty("pdf")]
        public InvoiceRenderingPdfOptions Pdf { get; set; }
    }
}
