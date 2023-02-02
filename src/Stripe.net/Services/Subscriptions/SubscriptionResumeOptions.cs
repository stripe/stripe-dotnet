// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionResumeOptions : BaseOptions
    {
        /// <summary>
        /// Either <c>now</c> or <c>unchanged</c>. Setting the value to <c>now</c> resets the
        /// subscription's billing cycle anchor to the current time (in UTC). Setting the value to
        /// <c>unchanged</c> advances the subscription's billing cycle anchor to the period that
        /// surrounds the current time. For more information, see the billing cycle <a
        /// href="https://stripe.com/docs/billing/subscriptions/billing-cycle">documentation</a>.
        /// One of: <c>now</c>, or <c>unchanged</c>.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        public SubscriptionBillingCycleAnchor BillingCycleAnchor { get; set; }

        /// <summary>
        /// Determines how to handle <a
        /// href="https://stripe.com/docs/subscriptions/billing-cycle#prorations">prorations</a>
        /// when the billing cycle changes (e.g., when switching plans, resetting
        /// <c>billing_cycle_anchor=now</c>, or starting a trial), or if an item's <c>quantity</c>
        /// changes. The default value is <c>create_prorations</c>.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// If set, the proration will be calculated as though the subscription was resumed at the
        /// given time. This can be used to apply exactly the same proration that was previewed with
        /// <a href="https://stripe.com/docs/api#retrieve_customer_invoice">upcoming invoice</a>
        /// endpoint.
        /// </summary>
        [JsonProperty("proration_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ProrationDate { get; set; }
    }
}
