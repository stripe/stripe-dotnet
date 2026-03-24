// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceParentQuoteDetails : StripeEntity<InvoiceParentQuoteDetails>
    {
        /// <summary>
        /// The quote that generated this invoice.
        /// </summary>
        [JsonProperty("quote")]
        [STJS.JsonPropertyName("quote")]
        public string Quote { get; set; }
    }
}
