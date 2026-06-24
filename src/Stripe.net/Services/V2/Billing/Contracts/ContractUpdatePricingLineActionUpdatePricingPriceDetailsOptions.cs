// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdatePricingLineActionUpdatePricingPriceDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Pricing override actions to apply to the overrides embedded on this pricing line.
        /// </summary>
        [JsonProperty("pricing_override_actions")]
        [STJS.JsonPropertyName("pricing_override_actions")]
        public List<ContractUpdatePricingLineActionUpdatePricingPriceDetailsPricingOverrideActionOptions> PricingOverrideActions { get; set; }

        /// <summary>
        /// Quantity changes for the pricing line. Setting this clears all future quantity changes.
        /// </summary>
        [JsonProperty("quantity_changes")]
        [STJS.JsonPropertyName("quantity_changes")]
        public List<ContractUpdatePricingLineActionUpdatePricingPriceDetailsQuantityChangeOptions> QuantityChanges { get; set; }
    }
}
