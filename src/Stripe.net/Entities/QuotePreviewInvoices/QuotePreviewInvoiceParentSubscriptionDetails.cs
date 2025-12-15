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

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class QuotePreviewInvoiceParentSubscriptionDetails : StripeEntity<QuotePreviewInvoiceParentSubscriptionDetails>, IHasMetadata
    {
        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> defined as
        /// subscription metadata when an invoice is created. Becomes an immutable snapshot of the
        /// subscription metadata at the time of invoice finalization. <em>Note: This attribute is
        /// populated only for invoices created on or after June 29, 2023.</em>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// If specified, payment collection for this subscription will be paused. Note that the
        /// subscription status will be unchanged and will not be updated to <c>paused</c>. Learn
        /// more about <a href="https://docs.stripe.com/billing/subscriptions/pause-payment">pausing
        /// collection</a>.
        /// </summary>
        [JsonProperty("pause_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pause_collection")]
#endif
        public QuotePreviewInvoiceParentSubscriptionDetailsPauseCollection PauseCollection { get; set; }

        #region Expandable Subscription

        /// <summary>
        /// (ID of the Subscription)
        /// The subscription that generated this invoice.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string SubscriptionId
        {
            get => this.InternalSubscription?.Id;
            set => this.InternalSubscription = SetExpandableFieldId(value, this.InternalSubscription);
        }

        /// <summary>
        /// (Expanded)
        /// The subscription that generated this invoice.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Subscription Subscription
        {
            get => this.InternalSubscription?.ExpandedObject;
            set => this.InternalSubscription = SetExpandableFieldObject(value, this.InternalSubscription);
        }

        [JsonProperty("subscription")]
        [JsonConverter(typeof(ExpandableFieldConverter<Subscription>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Subscription>))]
#endif
        internal ExpandableField<Subscription> InternalSubscription { get; set; }
        #endregion

        /// <summary>
        /// Only set for upcoming invoices that preview prorations. The time used to calculate
        /// prorations.
        /// </summary>
        [JsonProperty("subscription_proration_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_proration_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime SubscriptionProrationDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
