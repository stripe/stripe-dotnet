// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceParentQuoteDetails : StripeEntity<InvoiceParentQuoteDetails>
    {
        [JsonProperty("quote")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quote")]
#endif
        public string Quote { get; set; }
    }
}
