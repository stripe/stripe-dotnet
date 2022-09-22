// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class QuoteSubscriptionData : StripeEntity<QuoteSubscriptionData>
    {
        /// <summary>
        /// Configures when the subscription schedule generates prorations for phase transitions.
        /// Possible values are <c>prorate_on_next_phase</c> or <c>prorate_up_front</c> with the
        /// default being <c>prorate_on_next_phase</c>. <c>prorate_on_next_phase</c> will apply
        /// phase changes and generate prorations at transition time.<c>prorate_up_front</c> will
        /// bill for all phases within the current billing cycle up front.
        /// One of: <c>prorate_on_next_phase</c>, or <c>prorate_up_front</c>.
        /// </summary>
        [JsonProperty("billing_behavior")]
        public string BillingBehavior { get; set; }

        /// <summary>
        /// Whether the subscription will always start a new billing period when the quote is
        /// accepted.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        public string BillingCycleAnchor { get; set; }

        /// <summary>
        /// The subscription's description, meant to be displayable to the customer. Use this field
        /// to optionally store an explanation of the subscription.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// When creating a new subscription, the date of which the subscription schedule will start
        /// after the quote is accepted. This date is ignored if it is in the past when the quote is
        /// accepted. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("effective_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// Behavior of the subscription schedule and underlying subscription when it ends. Possible
        /// values are <c>release</c> and <c>cancel</c>.
        /// One of: <c>cancel</c>, or <c>release</c>.
        /// </summary>
        [JsonProperty("end_behavior")]
        public string EndBehavior { get; set; }

        #region Expandable FromSchedule

        /// <summary>
        /// (ID of the SubscriptionSchedule)
        /// The id of the subscription schedule that will be updated when the quote is accepted.
        /// </summary>
        [JsonIgnore]
        public string FromScheduleId
        {
            get => this.InternalFromSchedule?.Id;
            set => this.InternalFromSchedule = SetExpandableFieldId(value, this.InternalFromSchedule);
        }

        /// <summary>
        /// (Expanded)
        /// The id of the subscription schedule that will be updated when the quote is accepted.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public SubscriptionSchedule FromSchedule
        {
            get => this.InternalFromSchedule?.ExpandedObject;
            set => this.InternalFromSchedule = SetExpandableFieldObject(value, this.InternalFromSchedule);
        }

        [JsonProperty("from_schedule")]
        [JsonConverter(typeof(ExpandableFieldConverter<SubscriptionSchedule>))]
        internal ExpandableField<SubscriptionSchedule> InternalFromSchedule { get; set; }
        #endregion

        #region Expandable FromSubscription

        /// <summary>
        /// (ID of the Subscription)
        /// The id of the subscription that will be updated when the quote is accepted.
        /// </summary>
        [JsonIgnore]
        public string FromSubscriptionId
        {
            get => this.InternalFromSubscription?.Id;
            set => this.InternalFromSubscription = SetExpandableFieldId(value, this.InternalFromSubscription);
        }

        /// <summary>
        /// (Expanded)
        /// The id of the subscription that will be updated when the quote is accepted.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Subscription FromSubscription
        {
            get => this.InternalFromSubscription?.ExpandedObject;
            set => this.InternalFromSubscription = SetExpandableFieldObject(value, this.InternalFromSubscription);
        }

        [JsonProperty("from_subscription")]
        [JsonConverter(typeof(ExpandableFieldConverter<Subscription>))]
        internal ExpandableField<Subscription> InternalFromSubscription { get; set; }
        #endregion

        /// <summary>
        /// If specified, the invoicing for the given billing cycle iterations will be processed
        /// when the quote is accepted. Cannot be used with <c>effective_date</c>.
        /// </summary>
        [JsonProperty("prebilling")]
        public QuoteSubscriptionDataPrebilling Prebilling { get; set; }

        /// <summary>
        /// Determines how to handle <a
        /// href="https://stripe.com/docs/subscriptions/billing-cycle#prorations">prorations</a>
        /// when the quote is accepted.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// Integer representing the number of trial period days before the customer is charged for
        /// the first time.
        /// </summary>
        [JsonProperty("trial_period_days")]
        public long? TrialPeriodDays { get; set; }
    }
}
