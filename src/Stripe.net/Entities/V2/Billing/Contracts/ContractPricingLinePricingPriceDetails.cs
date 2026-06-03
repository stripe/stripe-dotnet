// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractPricingLinePricingPriceDetails : StripeEntity<ContractPricingLinePricingPriceDetails>
    {
        /// <summary>
        /// The ID of the V1 price.
        /// </summary>
        [JsonProperty("price")]
        [STJS.JsonPropertyName("price")]
        public string Price { get; set; }
    }
}
