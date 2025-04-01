// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceParentQuoteDetails : StripeEntity<InvoiceParentQuoteDetails>
    {
        /// <summary>
        /// The quote that generated this invoice.
        /// </summary>
        [JsonProperty("quote")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quote")]
#endif
        public string Quote { get; set; }
    }
}
