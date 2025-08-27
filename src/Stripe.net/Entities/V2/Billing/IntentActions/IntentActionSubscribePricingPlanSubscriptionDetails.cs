// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentActionSubscribePricingPlanSubscriptionDetails : StripeEntity<IntentActionSubscribePricingPlanSubscriptionDetails>, IHasMetadata
    {
        /// <summary>
        /// Configurations for the components of the Pricing Plan.
        /// </summary>
        [JsonProperty("component_configurations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("component_configurations")]
#endif
        public List<IntentActionSubscribePricingPlanSubscriptionDetailsComponentConfiguration> ComponentConfigurations { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// ID of the Pricing Plan to subscribe to.
        /// </summary>
        [JsonProperty("pricing_plan")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan")]
#endif
        public string PricingPlan { get; set; }

        /// <summary>
        /// ID of the created Pricing Plan Subscription. This is only present once the Billing
        /// Intent is committed and the Pricing Plan Subscription is created.
        /// </summary>
        [JsonProperty("pricing_plan_subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan_subscription")]
#endif
        public string PricingPlanSubscription { get; set; }

        /// <summary>
        /// Version of the Pricing Plan to use.
        /// </summary>
        [JsonProperty("pricing_plan_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan_version")]
#endif
        public string PricingPlanVersion { get; set; }
    }
}
