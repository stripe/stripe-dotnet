// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PricingPlanSubscriptionPricingPlanComponentDetailRecurringCreditGrantDetailsCreditGrantDetails : StripeEntity<PricingPlanSubscriptionPricingPlanComponentDetailRecurringCreditGrantDetailsCreditGrantDetails>
    {
        /// <summary>
        /// The amount of the credit grant.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public PricingPlanSubscriptionPricingPlanComponentDetailRecurringCreditGrantDetailsCreditGrantDetailsAmount Amount { get; set; }

        /// <summary>
        /// Defines the scope where the credit grant is applicable.
        /// </summary>
        [JsonProperty("applicability_config")]
        [STJS.JsonPropertyName("applicability_config")]
        public PricingPlanSubscriptionPricingPlanComponentDetailRecurringCreditGrantDetailsCreditGrantDetailsApplicabilityConfig ApplicabilityConfig { get; set; }

        /// <summary>
        /// The expiry configuration for the credit grant.
        /// </summary>
        [JsonProperty("expiry_config")]
        [STJS.JsonPropertyName("expiry_config")]
        public PricingPlanSubscriptionPricingPlanComponentDetailRecurringCreditGrantDetailsCreditGrantDetailsExpiryConfig ExpiryConfig { get; set; }
    }
}
