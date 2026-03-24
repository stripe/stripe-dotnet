// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CadenceSpendModifierMaxBillingPeriodSpendAmount : StripeEntity<CadenceSpendModifierMaxBillingPeriodSpendAmount>
    {
        /// <summary>
        /// The custom pricing unit amount. Present if type is <c>custom_pricing_unit</c>.
        /// </summary>
        [JsonProperty("custom_pricing_unit")]
        [STJS.JsonPropertyName("custom_pricing_unit")]
        public CadenceSpendModifierMaxBillingPeriodSpendAmountCustomPricingUnit CustomPricingUnit { get; set; }

        /// <summary>
        /// The type of the spend modifier amount.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
