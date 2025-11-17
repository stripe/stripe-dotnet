// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionScheduleBillingSchedule : StripeEntity<SubscriptionScheduleBillingSchedule>
    {
        /// <summary>
        /// Specifies which subscription items the billing schedule applies to.
        /// </summary>
        [JsonProperty("applies_to")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applies_to")]
#endif
        public List<SubscriptionScheduleBillingScheduleAppliesTo> AppliesTo { get; set; }

        /// <summary>
        /// Specifies the start of the billing period.
        /// </summary>
        [JsonProperty("bill_from")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bill_from")]
#endif
        public SubscriptionScheduleBillingScheduleBillFrom BillFrom { get; set; }

        /// <summary>
        /// Specifies the end of billing period.
        /// </summary>
        [JsonProperty("bill_until")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bill_until")]
#endif
        public SubscriptionScheduleBillingScheduleBillUntil BillUntil { get; set; }

        /// <summary>
        /// Unique identifier for the billing schedule.
        /// </summary>
        [JsonProperty("key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("key")]
#endif
        public string Key { get; set; }
    }
}
