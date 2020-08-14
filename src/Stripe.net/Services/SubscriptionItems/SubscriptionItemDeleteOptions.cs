namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionItemDeleteOptions : BaseOptions
    {
        /// <summary>
        /// Delete all usage for the given subscription item. Allowed only when the current plan's
        /// <c>usage_type</c> is <c>metered</c>.
        /// </summary>
        [JsonProperty("clear_usage")]
        public bool? ClearUsage { get; set; }

        /// <summary>
        /// Determines how to handle <a
        /// href="https://stripe.com/docs/subscriptions/billing-cycle#prorations">prorations</a>
        /// when the billing cycle changes (e.g., when switching plans, resetting
        /// <c>billing_cycle_anchor=now</c>, or starting a trial), or if an item's <c>quantity</c>
        /// changes. Valid values are <c>create_prorations</c>, <c>none</c>, or
        /// <c>always_invoice</c>.
        ///
        /// Passing <c>create_prorations</c> will cause proration invoice items to be created when
        /// applicable. These proration items will only be invoiced immediately under <a
        /// href="https://stripe.com/docs/subscriptions/upgrading-downgrading#immediate-payment">certain
        /// conditions</a>. In order to always invoice immediately for prorations, pass
        /// <c>always_invoice</c>.
        ///
        /// Prorations can be disabled by passing <c>none</c>.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// If set, the proration will be calculated as though the subscription was updated at the
        /// given time. This can be used to apply the same proration that was previewed with the <a
        /// href="https://stripe.com/docs/api#retrieve_customer_invoice">upcoming invoice</a>
        /// endpoint.
        /// </summary>
        [JsonProperty("proration_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ProrationDate { get; set; }
    }
}
