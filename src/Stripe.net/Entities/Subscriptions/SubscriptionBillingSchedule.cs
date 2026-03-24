// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionBillingSchedule : StripeEntity<SubscriptionBillingSchedule>
    {
        /// <summary>
        /// Specifies which subscription items the billing schedule applies to.
        /// </summary>
        [JsonProperty("applies_to")]
        [STJS.JsonPropertyName("applies_to")]
        public List<SubscriptionBillingScheduleAppliesTo> AppliesTo { get; set; }

        /// <summary>
        /// Specifies the start of the billing period.
        /// </summary>
        [JsonProperty("bill_from")]
        [STJS.JsonPropertyName("bill_from")]
        public SubscriptionBillingScheduleBillFrom BillFrom { get; set; }

        /// <summary>
        /// Specifies the end of billing period.
        /// </summary>
        [JsonProperty("bill_until")]
        [STJS.JsonPropertyName("bill_until")]
        public SubscriptionBillingScheduleBillUntil BillUntil { get; set; }

        /// <summary>
        /// Unique identifier for the billing schedule.
        /// </summary>
        [JsonProperty("key")]
        [STJS.JsonPropertyName("key")]
        public string Key { get; set; }
    }
}
