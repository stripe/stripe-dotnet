// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuoteSubscriptionData : StripeEntity<QuoteSubscriptionData>, IHasMetadata
    {
        /// <summary>
        /// Describes the period to bill for upon accepting the quote.
        /// </summary>
        [JsonProperty("bill_on_acceptance")]
        [STJS.JsonPropertyName("bill_on_acceptance")]
        public QuoteSubscriptionDataBillOnAcceptance BillOnAcceptance { get; set; }

        /// <summary>
        /// Configures when the subscription schedule generates prorations for phase transitions.
        /// Possible values are <c>prorate_on_next_phase</c> or <c>prorate_up_front</c> with the
        /// default being <c>prorate_on_next_phase</c>. <c>prorate_on_next_phase</c> will apply
        /// phase changes and generate prorations at transition time. <c>prorate_up_front</c> will
        /// bill for all phases within the current billing cycle up front.
        /// One of: <c>prorate_on_next_phase</c>, or <c>prorate_up_front</c>.
        /// </summary>
        [JsonProperty("billing_behavior")]
        [STJS.JsonPropertyName("billing_behavior")]
        public string BillingBehavior { get; set; }

        /// <summary>
        /// Whether the subscription will always start a new billing period when the quote is
        /// accepted.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        [STJS.JsonPropertyName("billing_cycle_anchor")]
        public string BillingCycleAnchor { get; set; }

        /// <summary>
        /// The billing mode of the quote.
        /// </summary>
        [JsonProperty("billing_mode")]
        [STJS.JsonPropertyName("billing_mode")]
        public QuoteSubscriptionDataBillingMode BillingMode { get; set; }

        /// <summary>
        /// Billing schedules that will be applied to the subscription or subscription schedule
        /// created from this quote.
        /// </summary>
        [JsonProperty("billing_schedules")]
        [STJS.JsonPropertyName("billing_schedules")]
        public List<QuoteSubscriptionDataBillingSchedule> BillingSchedules { get; set; }

        /// <summary>
        /// The subscription's description, meant to be displayable to the customer. Use this field
        /// to optionally store an explanation of the subscription for rendering in Stripe surfaces
        /// and certain local payment methods UIs.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// When creating a new subscription, the date of which the subscription schedule will start
        /// after the quote is accepted. This date is ignored if it is in the past when the quote is
        /// accepted. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("effective_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("effective_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// Behavior of the subscription schedule and underlying subscription when it ends.
        /// One of: <c>cancel</c>, or <c>release</c>.
        /// </summary>
        [JsonProperty("end_behavior")]
        [STJS.JsonPropertyName("end_behavior")]
        public string EndBehavior { get; set; }

        #region Expandable FromSubscription

        /// <summary>
        /// (ID of the Subscription)
        /// The id of the subscription that will be updated when the quote is accepted.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
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
        [STJS.JsonIgnore]
        public Subscription FromSubscription
        {
            get => this.InternalFromSubscription?.ExpandedObject;
            set => this.InternalFromSubscription = SetExpandableFieldObject(value, this.InternalFromSubscription);
        }

        [JsonProperty("from_subscription")]
        [JsonConverter(typeof(ExpandableFieldConverter<Subscription>))]
        [STJS.JsonPropertyName("from_subscription")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Subscription>))]
        internal ExpandableField<Subscription> InternalFromSubscription { get; set; }
        #endregion

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that will set
        /// metadata on the subscription or subscription schedule when the quote is accepted. If a
        /// recurring price is included in <c>line_items</c>, this field will be passed to the
        /// resulting subscription's <c>metadata</c> field. If
        /// <c>subscription_data.effective_date</c> is used, this field will be passed to the
        /// resulting subscription schedule's <c>phases.metadata</c> field. Unlike object-level
        /// metadata, this field is declarative. Updates will clear prior values.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Configures how the subscription schedule handles billing for phase transitions when the
        /// quote is accepted.
        /// One of: <c>billing_period_start</c>, or <c>phase_start</c>.
        /// </summary>
        [JsonProperty("phase_effective_at")]
        [STJS.JsonPropertyName("phase_effective_at")]
        public string PhaseEffectiveAt { get; set; }

        /// <summary>
        /// If specified, the invoicing for the given billing cycle iterations will be processed
        /// when the quote is accepted. Cannot be used with <c>effective_date</c>.
        /// </summary>
        [JsonProperty("prebilling")]
        [STJS.JsonPropertyName("prebilling")]
        public QuoteSubscriptionDataPrebilling Prebilling { get; set; }

        /// <summary>
        /// Determines how to handle <a
        /// href="https://docs.stripe.com/subscriptions/billing-cycle#prorations">prorations</a>
        /// when the quote is accepted.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        [STJS.JsonPropertyName("proration_behavior")]
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// Integer representing the number of trial period days before the customer is charged for
        /// the first time.
        /// </summary>
        [JsonProperty("trial_period_days")]
        [STJS.JsonPropertyName("trial_period_days")]
        public long? TrialPeriodDays { get; set; }
    }
}
