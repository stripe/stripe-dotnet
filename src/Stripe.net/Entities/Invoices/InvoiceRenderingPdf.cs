// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceRenderingPdf : StripeEntity<InvoiceRenderingPdf>
    {
        /// <summary>
        /// Page size of invoice pdf. Options include a4, letter, and auto. If set to auto, page
        /// size will be switched to a4 or letter based on customer locale.
        /// One of: <c>a4</c>, <c>auto</c>, or <c>letter</c>.
        /// </summary>
        [JsonProperty("page_size")]
        public string PageSize { get; set; }
    }
}
