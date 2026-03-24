// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CadenceSpendModifierMaxBillingPeriodSpendAmountCustomPricingUnit : StripeEntity<CadenceSpendModifierMaxBillingPeriodSpendAmountCustomPricingUnit>
    {
        /// <summary>
        /// The decimal value of custom pricing units, represented as a string.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
