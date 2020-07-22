namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionItemDeleteOptions : BaseOptions
    {
        /// <summary>
        /// Delete all usage for the given subscription item. Only allowed when the current plan's
        /// <c>usage_type</c> is metered.
        /// </summary>
        [JsonProperty("clear_usage")]
        public bool? ClearUsage { get; set; }

        /// <summary>
        /// Determines how to handle
        /// <a href="https://stripe.com/docs/billing/subscriptions/billing-cycle#prorations">prorations</a>
        /// when the billing cycle changes. The value defaults to
        /// <c>create_prorations</c>, indicating that proration invoice items should
        /// be created. Prorations can be disabled by setting the value to
        /// <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// If set, the proration will be calculated as though the subscription was updated at the
        /// given time. This can be used to apply the same proration that was previewed with the
        /// upcoming invoice endpoint.
        /// </summary>
        [JsonProperty("proration_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ProrationDate { get; set; }
    }
}
