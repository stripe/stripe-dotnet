// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceRenderingPdf : StripeEntity<InvoiceRenderingPdf>
    {
        /// <summary>
        /// Page size of invoice pdf. Options include a4, letter, and auto. If set to auto, page
        /// size will be switched to a4 or letter based on customer locale.
        /// One of: <c>a4</c>, <c>auto</c>, or <c>letter</c>.
        /// </summary>
        [JsonProperty("page_size")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("page_size")]
#endif

        public string PageSize { get; set; }
    }
}
