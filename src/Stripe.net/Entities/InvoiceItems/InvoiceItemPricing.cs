// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceItemPricing : StripeEntity<InvoiceItemPricing>
    {
        [JsonProperty("price_details")]
        [STJS.JsonPropertyName("price_details")]
        public InvoiceItemPricingPriceDetails PriceDetails { get; set; }

        /// <summary>
        /// The type of the pricing details.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The unit amount (in the <c>currency</c> specified) of the item which contains a decimal
        /// value with at most 12 decimal places.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
