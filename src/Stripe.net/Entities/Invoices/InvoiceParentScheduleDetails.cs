// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceParentScheduleDetails : StripeEntity<InvoiceParentScheduleDetails>
    {
        /// <summary>
        /// The schedule that generated this invoice.
        /// </summary>
        [JsonProperty("schedule")]
        [STJS.JsonPropertyName("schedule")]
        public string Schedule { get; set; }

        #region Expandable Subscription

        /// <summary>
        /// (ID of the Subscription)
        /// The subscription associated with this schedule.
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
        /// The subscription associated with this schedule.
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
    }
}
