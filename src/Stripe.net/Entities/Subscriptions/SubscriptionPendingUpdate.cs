// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionPendingUpdate : StripeEntity<SubscriptionPendingUpdate>
    {
        /// <summary>
        /// If the update is applied, determines the date of the first full invoice, and, for plans
        /// with <c>month</c> or <c>year</c> intervals, the day of the month for subsequent
        /// invoices. The timestamp is in UTC format.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_cycle_anchor")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? BillingCycleAnchor { get; set; }

        /// <summary>
        /// The point after which the changes reflected by this update will be discarded and no
        /// longer applied.
        /// </summary>
        [JsonProperty("expires_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// List of subscription items, each with an attached plan, that will be set if the update
        /// is applied.
        /// </summary>
        [JsonProperty("subscription_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_items")]
#endif

        public List<SubscriptionItem> SubscriptionItems { get; set; }

        /// <summary>
        /// Unix timestamp representing the end of the trial period the customer will get before
        /// being charged for the first time, if the update is applied.
        /// </summary>
        [JsonProperty("trial_end")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("trial_end")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? TrialEnd { get; set; }

        /// <summary>
        /// Indicates if a plan's <c>trial_period_days</c> should be applied to the subscription.
        /// Setting <c>trial_end</c> per subscription is preferred, and this defaults to
        /// <c>false</c>. Setting this flag to <c>true</c> together with <c>trial_end</c> is not
        /// allowed. See <a href="https://stripe.com/docs/billing/subscriptions/trials">Using trial
        /// periods on subscriptions</a> to learn more.
        /// </summary>
        [JsonProperty("trial_from_plan")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("trial_from_plan")]
#endif

        public bool? TrialFromPlan { get; set; }
    }
}
