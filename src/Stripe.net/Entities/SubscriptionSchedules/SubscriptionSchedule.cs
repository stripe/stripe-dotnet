// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A subscription schedule allows you to create and manage the lifecycle of a subscription
    /// by predefining expected changes.
    ///
    /// Related guide: <a
    /// href="https://stripe.com/docs/billing/subscriptions/subscription-schedules">Subscription
    /// schedules</a>.
    /// </summary>
    public class SubscriptionSchedule : StripeEntity<SubscriptionSchedule>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        #region Expandable Application

        /// <summary>
        /// (ID of the Application)
        /// ID of the Connect Application that created the schedule.
        /// </summary>
        [JsonIgnore]
        public string ApplicationId
        {
            get => this.InternalApplication?.Id;
            set => this.InternalApplication = SetExpandableFieldId(value, this.InternalApplication);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the Connect Application that created the schedule.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Application Application
        {
            get => this.InternalApplication?.ExpandedObject;
            set => this.InternalApplication = SetExpandableFieldObject(value, this.InternalApplication);
        }

        [JsonProperty("application")]
        [JsonConverter(typeof(ExpandableFieldConverter<Application>))]
        internal ExpandableField<Application> InternalApplication { get; set; }
        #endregion

        /// <summary>
        /// Time at which the subscription schedule was canceled. Measured in seconds since the Unix
        /// epoch.
        /// </summary>
        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Time at which the subscription schedule was completed. Measured in seconds since the
        /// Unix epoch.
        /// </summary>
        [JsonProperty("completed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Object representing the start and end dates for the current phase of the subscription
        /// schedule, if it is <c>active</c>.
        /// </summary>
        [JsonProperty("current_phase")]
        public SubscriptionScheduleCurrentPhase CurrentPhase { get; set; }

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// ID of the customer who owns the subscription schedule.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the customer who owns the subscription schedule.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        [JsonProperty("default_settings")]
        public SubscriptionScheduleDefaultSettings DefaultSettings { get; set; }

        /// <summary>
        /// Behavior of the subscription schedule and underlying subscription when it ends. Possible
        /// values are <c>release</c> or <c>cancel</c> with the default being <c>release</c>.
        /// <c>release</c> will end the subscription schedule and keep the underlying subscription
        /// running. <c>cancel</c> will end the subscription schedule and cancel the underlying
        /// subscription.
        /// One of: <c>cancel</c>, <c>none</c>, <c>release</c>, or <c>renew</c>.
        /// </summary>
        [JsonProperty("end_behavior")]
        public string EndBehavior { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Configuration for the subscription schedule's phases.
        /// </summary>
        [JsonProperty("phases")]
        public List<SubscriptionSchedulePhase> Phases { get; set; }

        /// <summary>
        /// Time at which the subscription schedule was released. Measured in seconds since the Unix
        /// epoch.
        /// </summary>
        [JsonProperty("released_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ReleasedAt { get; set; }

        /// <summary>
        /// ID of the subscription once managed by the subscription schedule (if it is released).
        /// </summary>
        [JsonProperty("released_subscription")]
        public string ReleasedSubscription { get; set; }

        /// <summary>
        /// The present status of the subscription schedule. Possible values are <c>not_started</c>,
        /// <c>active</c>, <c>completed</c>, <c>released</c>, and <c>canceled</c>. You can read more
        /// about the different states in our <a
        /// href="https://stripe.com/docs/billing/subscriptions/subscription-schedules">behavior
        /// guide</a>.
        /// One of: <c>active</c>, <c>canceled</c>, <c>completed</c>, <c>not_started</c>, or
        /// <c>released</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        #region Expandable Subscription

        /// <summary>
        /// (ID of the Subscription)
        /// ID of the subscription managed by the subscription schedule.
        /// </summary>
        [JsonIgnore]
        public string SubscriptionId
        {
            get => this.InternalSubscription?.Id;
            set => this.InternalSubscription = SetExpandableFieldId(value, this.InternalSubscription);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the subscription managed by the subscription schedule.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Subscription Subscription
        {
            get => this.InternalSubscription?.ExpandedObject;
            set => this.InternalSubscription = SetExpandableFieldObject(value, this.InternalSubscription);
        }

        [JsonProperty("subscription")]
        [JsonConverter(typeof(ExpandableFieldConverter<Subscription>))]
        internal ExpandableField<Subscription> InternalSubscription { get; set; }
        #endregion

        #region Expandable TestClock

        /// <summary>
        /// (ID of the TestHelpers.TestClock)
        /// ID of the test clock this subscription schedule belongs to.
        /// </summary>
        [JsonIgnore]
        public string TestClockId
        {
            get => this.InternalTestClock?.Id;
            set => this.InternalTestClock = SetExpandableFieldId(value, this.InternalTestClock);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the test clock this subscription schedule belongs to.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public TestHelpers.TestClock TestClock
        {
            get => this.InternalTestClock?.ExpandedObject;
            set => this.InternalTestClock = SetExpandableFieldObject(value, this.InternalTestClock);
        }

        [JsonProperty("test_clock")]
        [JsonConverter(typeof(ExpandableFieldConverter<TestHelpers.TestClock>))]
        internal ExpandableField<TestHelpers.TestClock> InternalTestClock { get; set; }
        #endregion
    }
}
