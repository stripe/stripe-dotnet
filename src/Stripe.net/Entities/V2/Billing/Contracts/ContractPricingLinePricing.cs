// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractPricingLinePricing : StripeEntity<ContractPricingLinePricing>
    {
        /// <summary>
        /// V1 price details. Present when <c>type</c> is <c>price</c>.
        /// </summary>
        [JsonProperty("price_details")]
        [STJS.JsonPropertyName("price_details")]
        public ContractPricingLinePricingPriceDetails PriceDetails { get; set; }

        /// <summary>
        /// The type of pricing.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
