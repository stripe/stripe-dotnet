// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionCheckoutItemPricingPlanSubscriptionItem : StripeEntity<SessionCheckoutItemPricingPlanSubscriptionItem>, IHasMetadata
    {
        [JsonProperty("pricing_plan")]
        [STJS.JsonPropertyName("pricing_plan")]
        public string PricingPlan { get; set; }

        [JsonProperty("pricing_plan_version")]
        [STJS.JsonPropertyName("pricing_plan_version")]
        public string PricingPlanVersion { get; set; }

        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("component_configurations")]
        [STJS.JsonPropertyName("component_configurations")]
        public Dictionary<string, SessionCheckoutItemPricingPlanSubscriptionItemComponentConfigurations> ComponentConfigurations { get; set; }

        [JsonProperty("pricing_plan_subscription")]
        [STJS.JsonPropertyName("pricing_plan_subscription")]
        public string PricingPlanSubscription { get; set; }

        [JsonProperty("billing_cadence")]
        [STJS.JsonPropertyName("billing_cadence")]
        public string BillingCadence { get; set; }
    }
}
