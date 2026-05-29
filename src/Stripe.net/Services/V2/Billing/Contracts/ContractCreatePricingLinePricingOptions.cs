// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreatePricingLinePricingOptions : INestedOptions
    {
        /// <summary>
        /// V1 price details. Required if <c>type</c> is <c>price</c>.
        /// </summary>
        [JsonProperty("price_details")]
        [STJS.JsonPropertyName("price_details")]
        public ContractCreatePricingLinePricingPriceDetailsOptions PriceDetails { get; set; }

        /// <summary>
        /// The type of pricing.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
