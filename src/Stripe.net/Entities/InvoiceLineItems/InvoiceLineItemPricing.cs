// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceLineItemPricing : StripeEntity<InvoiceLineItemPricing>
    {
        [JsonProperty("license_fee_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("license_fee_details")]
#endif
        public InvoiceLineItemPricingLicenseFeeDetails LicenseFeeDetails { get; set; }

        [JsonProperty("price_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price_details")]
#endif
        public InvoiceLineItemPricingPriceDetails PriceDetails { get; set; }

        [JsonProperty("rate_card_rate_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_card_rate_details")]
#endif
        public InvoiceLineItemPricingRateCardRateDetails RateCardRateDetails { get; set; }

        /// <summary>
        /// The type of the pricing details.
        /// One of: <c>license_fee_details</c>, <c>price_details</c>, or
        /// <c>rate_card_rate_details</c>.
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
