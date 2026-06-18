// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdatePricingLineActionAddPricingPriceDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the V1 price.
        /// </summary>
        [JsonProperty("price")]
        [STJS.JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// Pricing overrides embedded directly on this pricing line.
        /// </summary>
        [JsonProperty("pricing_overrides")]
        [STJS.JsonPropertyName("pricing_overrides")]
        public List<ContractUpdatePricingLineActionAddPricingPriceDetailsPricingOverrideOptions> PricingOverrides { get; set; }

        /// <summary>
        /// Quantity changes for the pricing line. For now, at most one entry is allowed. A quantity
        /// change clears all future quantity changes on this pricing line.
        /// </summary>
        [JsonProperty("quantity_changes")]
        [STJS.JsonPropertyName("quantity_changes")]
        public List<ContractUpdatePricingLineActionAddPricingPriceDetailsQuantityChangeOptions> QuantityChanges { get; set; }
    }
}
