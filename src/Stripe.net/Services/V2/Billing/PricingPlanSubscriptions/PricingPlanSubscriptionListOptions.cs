// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PricingPlanSubscriptionListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter by Billing Cadence ID. Mutually exclusive with <c>payer</c>, <c>pricing_plan</c>,
        /// and <c>pricing_plan_version</c>.
        /// </summary>
        [JsonProperty("billing_cadence")]
        [STJS.JsonPropertyName("billing_cadence")]
        public string BillingCadence { get; set; }

        /// <summary>
        /// Expand to include additional data such as discount_details, billing_cadence_details, or
        /// pricing_plan_component_details.
        /// One of: <c>discount_details</c>, or <c>pricing_plan_component_details</c>.
        /// </summary>
        [JsonProperty("include")]
        [STJS.JsonPropertyName("include")]
        public List<string> Include { get; set; }

        /// <summary>
        /// Filter by payer. Mutually exclusive with <c>billing_cadence</c>, <c>pricing_plan</c>,
        /// and <c>pricing_plan_version</c>.
        /// </summary>
        [JsonProperty("payer")]
        [STJS.JsonPropertyName("payer")]
        public PricingPlanSubscriptionListPayerOptions Payer { get; set; }

        /// <summary>
        /// Filter by PricingPlan ID. Mutually exclusive with <c>billing_cadence</c>, <c>payer</c>,
        /// and <c>pricing_plan_version</c>.
        /// </summary>
        [JsonProperty("pricing_plan")]
        [STJS.JsonPropertyName("pricing_plan")]
        public string PricingPlan { get; set; }

        /// <summary>
        /// Filter by Pricing Plan Version ID. Mutually exclusive with <c>billing_cadence</c>,
        /// <c>payer</c>, and <c>pricing_plan</c>.
        /// </summary>
        [JsonProperty("pricing_plan_version")]
        [STJS.JsonPropertyName("pricing_plan_version")]
        public string PricingPlanVersion { get; set; }

        /// <summary>
        /// Filter by servicing status.
        /// One of: <c>active</c>, <c>canceled</c>, <c>paused</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("servicing_status")]
        [STJS.JsonPropertyName("servicing_status")]
        public string ServicingStatus { get; set; }
    }
}
