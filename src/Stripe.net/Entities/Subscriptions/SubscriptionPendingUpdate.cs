// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionPendingUpdate : StripeEntity<SubscriptionPendingUpdate>, IHasMetadata
    {
        /// <summary>
        /// If the update is applied, determines the date of the first full invoice, and, for plans
        /// with <c>month</c> or <c>year</c> intervals, the day of the month for subsequent
        /// invoices. The timestamp is in UTC format.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("billing_cycle_anchor")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? BillingCycleAnchor { get; set; }

        /// <summary>
        /// The pending subscription-level discount that will be applied when the pending update is
        /// applied.
        /// </summary>
        [JsonProperty("discount")]
        [STJS.JsonPropertyName("discount")]
        public Discount Discount { get; set; }

        #region Expandable Discounts

        /// <summary>
        /// (IDs of the Discounts)
        /// The discounts that will be applied to the subscription when the pending update is
        /// applied. Use <c>expand[]=discounts</c> to expand each discount.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public List<string> DiscountIds
        {
            get => this.InternalDiscounts?.Select((x) => x.Id).ToList();
            set => this.InternalDiscounts = SetExpandableArrayIds<Discount>(value);
        }

        /// <summary>
        /// (Expanded)
        /// The discounts that will be applied to the subscription when the pending update is
        /// applied. Use <c>expand[]=discounts</c> to expand each discount.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public List<Discount> Discounts
        {
            get => this.InternalDiscounts?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalDiscounts = SetExpandableArrayObjects(value);
        }

        [JsonProperty("discounts", ItemConverterType = typeof(ExpandableFieldConverter<Discount>))]
        [STJS.JsonPropertyName("discounts")]
        internal List<ExpandableField<Discount>> InternalDiscounts { get; set; }
        #endregion

        /// <summary>
        /// The point after which the changes reflected by this update will be discarded and no
        /// longer applied.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The number of iterations of prebilling to apply.
        /// </summary>
        [JsonProperty("prebilling_iterations")]
        [STJS.JsonPropertyName("prebilling_iterations")]
        public long? PrebillingIterations { get; set; }

        /// <summary>
        /// List of subscription items, each with an attached plan, that will be set if the update
        /// is applied.
        /// </summary>
        [JsonProperty("subscription_items")]
        [STJS.JsonPropertyName("subscription_items")]
        public List<SubscriptionItem> SubscriptionItems { get; set; }

        /// <summary>
        /// Unix timestamp representing the end of the trial period the customer will get before
        /// being charged for the first time, if the update is applied.
        /// </summary>
        [JsonProperty("trial_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("trial_end")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? TrialEnd { get; set; }

        /// <summary>
        /// Indicates if a plan's <c>trial_period_days</c> should be applied to the subscription.
        /// Setting <c>trial_end</c> per subscription is preferred, and this defaults to
        /// <c>false</c>. Setting this flag to <c>true</c> together with <c>trial_end</c> is not
        /// allowed. See <a href="https://docs.stripe.com/billing/subscriptions/trials">Using trial
        /// periods on subscriptions</a> to learn more.
        /// </summary>
        [JsonProperty("trial_from_plan")]
        [STJS.JsonPropertyName("trial_from_plan")]
        public bool? TrialFromPlan { get; set; }
    }
}
