// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteSubscriptionDataOverrideBillingSchedule : StripeEntity<QuoteSubscriptionDataOverrideBillingSchedule>
    {
        /// <summary>
        /// Specifies which subscription items the billing schedule applies to.
        /// </summary>
        [JsonProperty("applies_to")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applies_to")]
#endif
        public List<QuoteSubscriptionDataOverrideBillingScheduleAppliesTo> AppliesTo { get; set; }

        /// <summary>
        /// Specifies the start of the billing period.
        /// </summary>
        [JsonProperty("bill_from")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bill_from")]
#endif
        public QuoteSubscriptionDataOverrideBillingScheduleBillFrom BillFrom { get; set; }

        [JsonProperty("bill_until")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bill_until")]
#endif
        public QuoteSubscriptionDataOverrideBillingScheduleBillUntil BillUntil { get; set; }

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
