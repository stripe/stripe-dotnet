// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceLineItemPricing : StripeEntity<InvoiceLineItemPricing>
    {
        [JsonProperty("license_fee_details")]
        [STJS.JsonPropertyName("license_fee_details")]
        public InvoiceLineItemPricingLicenseFeeDetails LicenseFeeDetails { get; set; }

        [JsonProperty("price_details")]
        [STJS.JsonPropertyName("price_details")]
        public InvoiceLineItemPricingPriceDetails PriceDetails { get; set; }

        [JsonProperty("rate_card_custom_pricing_unit_overage_rate_details")]
        [STJS.JsonPropertyName("rate_card_custom_pricing_unit_overage_rate_details")]
        public InvoiceLineItemPricingRateCardCustomPricingUnitOverageRateDetails RateCardCustomPricingUnitOverageRateDetails { get; set; }

        [JsonProperty("rate_card_rate_details")]
        [STJS.JsonPropertyName("rate_card_rate_details")]
        public InvoiceLineItemPricingRateCardRateDetails RateCardRateDetails { get; set; }

        /// <summary>
        /// The type of the pricing details.
        /// One of: <c>license_fee_details</c>, <c>price_details</c>,
        /// <c>rate_card_custom_pricing_unit_overage_rate_details</c>, or
        /// <c>rate_card_rate_details</c>.
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
