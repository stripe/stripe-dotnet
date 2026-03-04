// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentActionModifyPricingPlanSubscriptionDetailsOverridesPartialPeriodBehavior : StripeEntity<IntentActionModifyPricingPlanSubscriptionDetailsOverridesPartialPeriodBehavior>
    {
        /// <summary>
        /// The type of behavior to override.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// Overrides the behavior for license fee components when the action takes effect during
        /// the service period.
        /// </summary>
        [JsonProperty("license_fee")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("license_fee")]
#endif
        public IntentActionModifyPricingPlanSubscriptionDetailsOverridesPartialPeriodBehaviorLicenseFee LicenseFee { get; set; }
    }
}
