// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PricingPlanSubscriptionListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter by Billing Cadence ID. Mutually exclusive with <c>payer</c>, <c>pricing_plan</c>,
        /// and <c>pricing_plan_version</c>.
        /// </summary>
        [JsonProperty("billing_cadence")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_cadence")]
#endif
        public string BillingCadence { get; set; }

        /// <summary>
        /// Filter by payer. Mutually exclusive with <c>billing_cadence</c>, <c>pricing_plan</c>,
        /// and <c>pricing_plan_version</c>.
        /// </summary>
        [JsonProperty("payer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payer")]
#endif
        public PricingPlanSubscriptionListPayerOptions Payer { get; set; }

        /// <summary>
        /// Filter by PricingPlan ID. Mutually exlcusive with <c>billing_cadence</c>, <c>payer</c>,
        /// and <c>pricing_plan_version</c>.
        /// </summary>
        [JsonProperty("pricing_plan")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan")]
#endif
        public string PricingPlan { get; set; }

        /// <summary>
        /// Filter by Pricing Plan Version ID. Mutually exlcusive with <c>billing_cadence</c>,
        /// <c>payer</c>, and <c>pricing_plan</c>.
        /// </summary>
        [JsonProperty("pricing_plan_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan_version")]
#endif
        public string PricingPlanVersion { get; set; }

        /// <summary>
        /// Filter by servicing status.
        /// One of: <c>active</c>, <c>canceled</c>, <c>paused</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("servicing_status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("servicing_status")]
#endif
        public string ServicingStatus { get; set; }
    }
}
