// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceItemPricing : StripeEntity<InvoiceItemPricing>
    {
        [JsonProperty("price_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price_details")]
#endif
        public InvoiceItemPricingPriceDetails PriceDetails { get; set; }

        /// <summary>
        /// The type of the pricing details.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// The unit amount (in the <c>currency</c> specified) of the item which contains a decimal
        /// value with at most 12 decimal places.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_amount_decimal")]
#endif
        public decimal? UnitAmountDecimal { get; set; }
    }
}
