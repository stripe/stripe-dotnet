// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceParentSubscriptionDetails : StripeEntity<InvoiceParentSubscriptionDetails>, IHasMetadata
    {
        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> defined as
        /// subscription metadata when an invoice is created. Becomes an immutable snapshot of the
        /// subscription metadata at the time of invoice finalization. <em>Note: This attribute is
        /// populated only for invoices created on or after June 29, 2023.</em>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        #region Expandable Subscription

        /// <summary>
        /// (ID of the Subscription)
        /// The subscription that generated this invoice.
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
        /// The subscription that generated this invoice.
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
        /// Only set for upcoming invoices that preview prorations. The time used to calculate
        /// prorations.
        /// </summary>
        [JsonProperty("subscription_proration_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("subscription_proration_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime SubscriptionProrationDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
