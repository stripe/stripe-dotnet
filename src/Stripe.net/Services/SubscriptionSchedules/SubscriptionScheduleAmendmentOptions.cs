// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionScheduleAmendmentOptions : INestedOptions
    {
        /// <summary>
        /// Details to identify the end of the time range modified by the proposed change. If not
        /// supplied, the amendment is considered a point-in-time operation that only affects the
        /// exact timestamp at <c>amendment_start</c>, and a restricted set of attributes is
        /// supported on the amendment.
        /// </summary>
        [JsonProperty("amendment_end")]
        public SubscriptionScheduleAmendmentAmendmentEndOptions AmendmentEnd { get; set; }

        /// <summary>
        /// Details to identify the earliest timestamp where the proposed change should take effect.
        /// </summary>
        [JsonProperty("amendment_start")]
        public SubscriptionScheduleAmendmentAmendmentStartOptions AmendmentStart { get; set; }

        /// <summary>
        /// For a point-in-time amendment, this attribute lets you set or update whether the
        /// subscription's billing cycle anchor is reset at the <c>amendment_start</c> timestamp.
        /// One of: <c>amendment_start</c>, or <c>automatic</c>.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        public string BillingCycleAnchor { get; set; }

        /// <summary>
        /// Changes to the coupons being redeemed or discounts being applied during the amendment
        /// time span.
        /// </summary>
        [JsonProperty("discount_actions")]
        public List<SubscriptionScheduleAmendmentDiscountActionOptions> DiscountActions { get; set; }

        /// <summary>
        /// Changes to the subscription items during the amendment time span.
        /// </summary>
        [JsonProperty("item_actions")]
        public List<SubscriptionScheduleAmendmentItemActionOptions> ItemActions { get; set; }

        /// <summary>
        /// Changes to how Stripe handles prorations during the amendment time span. Affects if and
        /// how prorations are created when a future phase starts. In cases where the amendment
        /// changes the currently active phase, it is used to determine whether or how to prorate
        /// now, at the time of the request. Also supported as a point-in-time operation when
        /// <c>amendment_end</c> is <c>null</c>.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }
    }
}
