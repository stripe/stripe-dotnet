// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2BillingPricingPlanComponentUpdatedEventData : StripeEntity<V2BillingPricingPlanComponentUpdatedEventData>
    {
        /// <summary>
        /// The ID of the PricingPlan that the PricingPlanComponent belongs to.
        /// </summary>
        [JsonProperty("pricing_plan_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan_id")]
#endif
        public string PricingPlanId { get; set; }
    }
}
