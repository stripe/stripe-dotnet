// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionResumeOptions : BaseOptions
    {
        /// <summary>
        /// The billing cycle anchor that applies when the subscription is resumed. Either
        /// <c>now</c> or <c>unchanged</c>. The default is <c>now</c>. For more information, see the
        /// billing cycle <a
        /// href="https://stripe.com/docs/billing/subscriptions/billing-cycle">documentation</a>.
        /// One of: <c>now</c>, or <c>unchanged</c>.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_cycle_anchor")]
#endif

        public SubscriptionBillingCycleAnchor BillingCycleAnchor { get; set; }

        /// <summary>
        /// Determines how to handle <a
        /// href="https://stripe.com/docs/billing/subscriptions/prorations">prorations</a> when the
        /// billing cycle changes (e.g., when switching plans, resetting
        /// <c>billing_cycle_anchor=now</c>, or starting a trial), or if an item's <c>quantity</c>
        /// changes. The default value is <c>create_prorations</c>.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("proration_behavior")]
#endif

        public string ProrationBehavior { get; set; }

        /// <summary>
        /// If set, the proration will be calculated as though the subscription was resumed at the
        /// given time. This can be used to apply exactly the same proration that was previewed with
        /// <a href="https://stripe.com/docs/api#retrieve_customer_invoice">upcoming invoice</a>
        /// endpoint.
        /// </summary>
        [JsonProperty("proration_date")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("proration_date")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ProrationDate { get; set; }
    }
}
