// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceItemParentPricingPlanSubscriptionDetails : StripeEntity<InvoiceItemParentPricingPlanSubscriptionDetails>
    {
        /// <summary>
        /// The pricing plan subscription that manages this charge.
        /// </summary>
        [JsonProperty("pricing_plan_subscription")]
        [STJS.JsonPropertyName("pricing_plan_subscription")]
        public string PricingPlanSubscription { get; set; }

        /// <summary>
        /// The pricing plan version at the time this charge was generated.
        /// </summary>
        [JsonProperty("pricing_plan_version")]
        [STJS.JsonPropertyName("pricing_plan_version")]
        public string PricingPlanVersion { get; set; }
    }
}
