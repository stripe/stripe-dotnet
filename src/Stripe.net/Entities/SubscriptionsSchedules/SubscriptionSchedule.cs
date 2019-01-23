namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionSchedule : StripeEntity<SubscriptionSchedule>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object’s type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// One of <see cref="Billing" />. When charging automatically, Stripe will attempt to pay
        /// this subscription at the end of the cycle using the default source attached to the
        /// customer. When sending an invoice, Stripe will email your customer an invoice with
        /// payment instructions.
        /// </summary>
        [JsonProperty("billing")]
        public Billing? Billing { get; set; }

        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the subscription advanced to a
        /// new billing period
        /// </summary>
        [JsonProperty("billing_thresholds")]
        public SubscriptionBillingThresholds BillingThresholds { get; set; }

        /// <summary>
        /// Time at which the subscription schedule was canceled. Measured in seconds since the
        /// Unix epoch.
        /// </summary>
        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Time at which the subscription schedule was completed. Measured in seconds since the
        /// Unix epoch.
        /// </summary>
        [JsonProperty("completed_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Object representing the start and end dates for the current phase of the subscription
        /// schedule, if it is <c>active</c>.
        /// </summary>
        [JsonProperty("current_phase")]
        public SubscriptionScheduleCurrentPhase CurrentPhase { get; set; }

        #region Expandable Customer

        /// <summary>
        /// ID of the <see cref="Customer"/> associated with the subscription schedule.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string CustomerId { get; set; }

        /// <summary>
        /// (Expanded) The <see cref="Customer"/> associated with the subscription schedule.
        /// </summary>
        [JsonIgnore]
        public Customer Customer { get; set; }

        [JsonProperty("customer")]
        internal object InternalCustomer
        {
            get
            {
                return this.Customer ?? (object)this.CustomerId;
            }

            set
            {
                StringOrObject<Customer>.Map(value, s => this.CustomerId = s, o => this.Customer = o);
            }
        }
        #endregion

        /// <summary>
        /// The schedule's default invoice settings.
        /// </summary>
        [JsonProperty("invoice_settings")]
        public SubscriptionScheduleInvoiceSettings InvoiceSettings { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value
        /// <c>false</c> if the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a subscription schedule object.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Configuration for the subscription schedule’s phases.
        /// </summary>
        [JsonProperty("phases")]
        public List<SubscriptionSchedulePhase> Phases { get; set; }

        /// <summary>
        /// Time at which the subscription schedule was released. Measured in seconds since the
        /// Unix epoch.
        /// </summary>
        [JsonProperty("released_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? ReleasedAt { get; set; }

        /// <summary>
        /// ID of the subscription once managed by the subscription schedule (if it is released).
        /// </summary>
        [JsonProperty("released_subscription")]
        public string ReleasedSubscriptionId { get; set; }

        /// <summary>
        /// Behavior of the subscription schedule and underlying subscription when it ends.
        /// </summary>
        [JsonProperty("renewal_behavior")]
        public string RenewalBehavior { get; set; }

        /// <summary>
        /// Interval and duration at which the subscription schedule renews for when it ends if
        /// <c>renewal_behavior</c> is <c>renew</c>.
        /// </summary>
        [JsonProperty("renewal_interval")]
        public SubscriptionScheduleRenewalInterval RenewalInterval { get; set; }

        /// <summary>
        /// ID of the current revision of the subscription schedule.
        /// </summary>
        [JsonProperty("revision")]
        public string RevisionId { get; set; }

        /// <summary>
        /// Possible values are <c>active</c>, <c>canceled</c>, <c>completed</c>,
        /// <c>not_started</c>, <c>released</c> and <c>renewal_behavior</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        #region Expandable Subscription

        /// <summary>
        /// ID of the <see cref="Subscription"/> associated with the subscription schedule.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// (Expanded) The <see cref="Subscription"/> associated with the subscription schedule.
        /// </summary>
        [JsonIgnore]
        public Subscription Subscription { get; set; }

        [JsonProperty("subscription")]
        internal object InternalSubscription
        {
            get
            {
                return this.Subscription ?? (object)this.SubscriptionId;
            }

            set
            {
                StringOrObject<Subscription>.Map(value, s => this.SubscriptionId = s, o => this.Subscription = o);
            }
        }
        #endregion
    }
}
