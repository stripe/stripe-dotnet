// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentActionSubscribePricingPlanSubscriptionDetailsOverridesPartialPeriodBehavior : StripeEntity<IntentActionSubscribePricingPlanSubscriptionDetailsOverridesPartialPeriodBehavior>
    {
        /// <summary>
        /// The type of behavior to override.
        /// One of: <c>license_fee</c>, or <c>recurring_credit_grant</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Overrides the behavior for license fee components when the action takes effect during
        /// the service period.
        /// </summary>
        [JsonProperty("license_fee")]
        [STJS.JsonPropertyName("license_fee")]
        public IntentActionSubscribePricingPlanSubscriptionDetailsOverridesPartialPeriodBehaviorLicenseFee LicenseFee { get; set; }
    }
}
