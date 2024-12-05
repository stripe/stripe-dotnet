// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceRenderingPdfOptions : INestedOptions
    {
        /// <summary>
        /// Page size for invoice PDF. Can be set to <c>a4</c>, <c>letter</c>, or <c>auto</c>. If
        /// set to <c>auto</c>, invoice PDF page size defaults to <c>a4</c> for customers with
        /// Japanese locale and <c>letter</c> for customers with other locales.
        /// One of: <c>a4</c>, <c>auto</c>, or <c>letter</c>.
        /// </summary>
        [JsonProperty("page_size")]
        public string PageSize { get; set; }
    }
}
