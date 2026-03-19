// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2BillingPricingPlanVersionCreatedEventData : StripeEntity<V2BillingPricingPlanVersionCreatedEventData>
    {
        /// <summary>
        /// The ID of the PricingPlan that the PricingPlanVersion belongs to.
        /// </summary>
        [JsonProperty("pricing_plan_id")]
        [STJS.JsonPropertyName("pricing_plan_id")]
        public string PricingPlanId { get; set; }
    }
}
