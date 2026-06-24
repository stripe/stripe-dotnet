// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractPricingLinesDataPricingPriceDetails : StripeEntity<ContractPricingLinesDataPricingPriceDetails>
    {
        /// <summary>
        /// The current quantity on this pricing line.
        /// </summary>
        [JsonProperty("current_quantity")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("current_quantity")]
        public decimal CurrentQuantity { get; set; }

        /// <summary>
        /// The ID of the V1 price.
        /// </summary>
        [JsonProperty("price")]
        [STJS.JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// The overwrite_price overrides embedded directly on this pricing line.
        /// </summary>
        [JsonProperty("pricing_overrides")]
        [STJS.JsonPropertyName("pricing_overrides")]
        public ContractPricingLinesDataPricingPriceDetailsPricingOverrides PricingOverrides { get; set; }
    }
}
