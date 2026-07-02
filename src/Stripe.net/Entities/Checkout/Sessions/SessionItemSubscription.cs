// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionItemSubscription : StripeEntity<SessionItemSubscription>, IHasMetadata
    {
        /// <summary>
        /// The description for the subscription.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The items in the subscription.
        /// </summary>
        [JsonProperty("items")]
        [STJS.JsonPropertyName("items")]
        public List<SessionItemSubscriptionItem> Items { get; set; }

        /// <summary>
        /// Set of key-value pairs attached to the subscription.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Specifies an interval for how often to bill for any pending invoice items.
        /// </summary>
        [JsonProperty("pending_invoice_item_interval")]
        [STJS.JsonPropertyName("pending_invoice_item_interval")]
        public SessionItemSubscriptionPendingInvoiceItemInterval PendingInvoiceItemInterval { get; set; }

        /// <summary>
        /// Determines how to handle prorations when the subscription is updated.
        /// One of: <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        [STJS.JsonPropertyName("proration_behavior")]
        public string ProrationBehavior { get; set; }

        #region Expandable Subscription

        /// <summary>
        /// (ID of the Subscription)
        /// The ID of the <a href="https://docs.stripe.com/api/subscriptions">Subscription</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string SubscriptionId
        {
            get => this.InternalSubscription?.Id;
            set => this.InternalSubscription = SetExpandableFieldId(value, this.InternalSubscription);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the <a href="https://docs.stripe.com/api/subscriptions">Subscription</a>.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Subscription Subscription
        {
            get => this.InternalSubscription?.ExpandedObject;
            set => this.InternalSubscription = SetExpandableFieldObject(value, this.InternalSubscription);
        }

        [JsonProperty("subscription")]
        [JsonConverter(typeof(ExpandableFieldConverter<Subscription>))]
        [STJS.JsonPropertyName("subscription")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Subscription>))]
        internal ExpandableField<Subscription> InternalSubscription { get; set; }
        #endregion

        /// <summary>
        /// The Unix timestamp marking when the trial period ends.
        /// </summary>
        [JsonProperty("trial_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("trial_end")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? TrialEnd { get; set; }

        /// <summary>
        /// The number of trial period days before the customer is charged for the first time.
        /// </summary>
        [JsonProperty("trial_period_days")]
        [STJS.JsonPropertyName("trial_period_days")]
        public long? TrialPeriodDays { get; set; }

        /// <summary>
        /// Settings related to subscription trials.
        /// </summary>
        [JsonProperty("trial_settings")]
        [STJS.JsonPropertyName("trial_settings")]
        public SessionItemSubscriptionTrialSettings TrialSettings { get; set; }
    }
}
