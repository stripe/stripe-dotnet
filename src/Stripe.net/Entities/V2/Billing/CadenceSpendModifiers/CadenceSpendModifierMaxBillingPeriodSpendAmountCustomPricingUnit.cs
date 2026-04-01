// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CadenceSpendModifierMaxBillingPeriodSpendAmountCustomPricingUnit : StripeEntity<CadenceSpendModifierMaxBillingPeriodSpendAmountCustomPricingUnit>, IHasId
    {
        /// <summary>
        /// The id of the custom pricing unit.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The decimal value of custom pricing units, represented as a string.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
