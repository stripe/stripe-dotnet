// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CadenceSpendModifierMaxBillingPeriodSpendCustomPricingUnitOverageRate : StripeEntity<CadenceSpendModifierMaxBillingPeriodSpendCustomPricingUnitOverageRate>, IHasId
    {
        /// <summary>
        /// ID of the custom pricing unit overage rate.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }
    }
}
