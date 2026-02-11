// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CadenceSpendModifierMaxBillingPeriodSpendAmountCustomPricingUnit : StripeEntity<CadenceSpendModifierMaxBillingPeriodSpendAmountCustomPricingUnit>
    {
        /// <summary>
        /// The decimal value of custom pricing units, represented as a string.
        /// </summary>
        [JsonProperty("value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value")]
#endif
        public string Value { get; set; }
    }
}
