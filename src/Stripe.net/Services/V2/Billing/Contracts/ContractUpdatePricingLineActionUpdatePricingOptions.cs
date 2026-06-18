// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdatePricingLineActionUpdatePricingOptions : INestedOptions
    {
        /// <summary>
        /// V1 price details. Present when the pricing line type is <c>price</c>.
        /// </summary>
        [JsonProperty("price_details")]
        [STJS.JsonPropertyName("price_details")]
        public ContractUpdatePricingLineActionUpdatePricingPriceDetailsOptions PriceDetails { get; set; }
    }
}
