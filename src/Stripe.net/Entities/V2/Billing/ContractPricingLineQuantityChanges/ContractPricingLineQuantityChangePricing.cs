// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractPricingLineQuantityChangePricing : StripeEntity<ContractPricingLineQuantityChangePricing>
    {
        /// <summary>
        /// The ID of the V1 price. Present when <c>type</c> is <c>price</c>.
        /// </summary>
        [JsonProperty("price")]
        [STJS.JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// The type of pricing.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
