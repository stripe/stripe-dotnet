// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PricingPlanSubscriptionPricingPlanComponentDetailRecurringCreditGrantDetails : StripeEntity<PricingPlanSubscriptionPricingPlanComponentDetailRecurringCreditGrantDetails>
    {
        /// <summary>
        /// Credit grant details, present when type is CREDIT_GRANT.
        /// </summary>
        [JsonProperty("credit_grant_details")]
        [STJS.JsonPropertyName("credit_grant_details")]
        public PricingPlanSubscriptionPricingPlanComponentDetailRecurringCreditGrantDetailsCreditGrantDetails CreditGrantDetails { get; set; }

        /// <summary>
        /// Credit grant per tenant details, present when type is CREDIT_GRANT_PER_TENANT.
        /// </summary>
        [JsonProperty("credit_grant_per_tenant_details")]
        [STJS.JsonPropertyName("credit_grant_per_tenant_details")]
        public PricingPlanSubscriptionPricingPlanComponentDetailRecurringCreditGrantDetailsCreditGrantPerTenantDetails CreditGrantPerTenantDetails { get; set; }

        /// <summary>
        /// The ID of the Recurring Credit Grant.
        /// </summary>
        [JsonProperty("recurring_credit_grant")]
        [STJS.JsonPropertyName("recurring_credit_grant")]
        public string RecurringCreditGrant { get; set; }

        /// <summary>
        /// The service cycle configuration.
        /// </summary>
        [JsonProperty("service_cycle")]
        [STJS.JsonPropertyName("service_cycle")]
        public PricingPlanSubscriptionPricingPlanComponentDetailRecurringCreditGrantDetailsServiceCycle ServiceCycle { get; set; }

        /// <summary>
        /// The type of the recurring credit grant.
        /// One of: <c>credit_grant</c>, or <c>credit_grant_per_tenant</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
