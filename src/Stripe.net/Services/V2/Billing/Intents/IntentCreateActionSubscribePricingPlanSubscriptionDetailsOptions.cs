// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateActionSubscribePricingPlanSubscriptionDetailsOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// Configurations for the components of the pricing plan.
        /// </summary>
        [JsonProperty("component_configurations")]
        [STJS.JsonPropertyName("component_configurations")]
        public List<IntentCreateActionSubscribePricingPlanSubscriptionDetailsComponentConfigurationOptions> ComponentConfigurations { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Configurations for overriding behaviors related to the subscription.
        /// </summary>
        [JsonProperty("overrides")]
        [STJS.JsonPropertyName("overrides")]
        public IntentCreateActionSubscribePricingPlanSubscriptionDetailsOverridesOptions Overrides { get; set; }

        /// <summary>
        /// ID of the Pricing Plan to subscribe to.
        /// </summary>
        [JsonProperty("pricing_plan")]
        [STJS.JsonPropertyName("pricing_plan")]
        public string PricingPlan { get; set; }

        /// <summary>
        /// Version of the Pricing Plan to use.
        /// </summary>
        [JsonProperty("pricing_plan_version")]
        [STJS.JsonPropertyName("pricing_plan_version")]
        public string PricingPlanVersion { get; set; }
    }
}
