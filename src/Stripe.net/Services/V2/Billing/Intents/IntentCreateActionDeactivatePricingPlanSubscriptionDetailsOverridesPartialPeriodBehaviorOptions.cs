// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateActionDeactivatePricingPlanSubscriptionDetailsOverridesPartialPeriodBehaviorOptions : INestedOptions
    {
        /// <summary>
        /// The type of behavior to override.
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
        public IntentCreateActionDeactivatePricingPlanSubscriptionDetailsOverridesPartialPeriodBehaviorLicenseFeeOptions LicenseFee { get; set; }
    }
}
