// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionCancellationDetails : StripeEntity<SubscriptionCancellationDetails>
    {
        /// <summary>
        /// Additional comments about why the user canceled the subscription, if the subscription
        /// was canceled explicitly by the user.
        /// </summary>
        [JsonProperty("comment")]
        [STJS.JsonPropertyName("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// The customer submitted reason for why they canceled, if the subscription was canceled
        /// explicitly by the user.
        /// One of: <c>customer_service</c>, <c>low_quality</c>, <c>missing_features</c>,
        /// <c>other</c>, <c>switched_service</c>, <c>too_complex</c>, <c>too_expensive</c>, or
        /// <c>unused</c>.
        /// </summary>
        [JsonProperty("feedback")]
        [STJS.JsonPropertyName("feedback")]
        public string Feedback { get; set; }

        #region Expandable FeedbackOption

        /// <summary>
        /// (ID of the Billing.FeedbackOptions)
        /// Customized feedback options that provide deeper insight into why the subscription was
        /// canceled, if the subscription was canceled explicitly by the user.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string FeedbackOptionId
        {
            get => this.InternalFeedbackOption?.Id;
            set => this.InternalFeedbackOption = SetExpandableFieldId(value, this.InternalFeedbackOption);
        }

        /// <summary>
        /// (Expanded)
        /// Customized feedback options that provide deeper insight into why the subscription was
        /// canceled, if the subscription was canceled explicitly by the user.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Billing.FeedbackOptions FeedbackOption
        {
            get => this.InternalFeedbackOption?.ExpandedObject;
            set => this.InternalFeedbackOption = SetExpandableFieldObject(value, this.InternalFeedbackOption);
        }

        [JsonProperty("feedback_option")]
        [JsonConverter(typeof(ExpandableFieldConverter<Billing.FeedbackOptions>))]
        [STJS.JsonPropertyName("feedback_option")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Billing.FeedbackOptions>))]
        internal ExpandableField<Billing.FeedbackOptions> InternalFeedbackOption { get; set; }
        #endregion

        /// <summary>
        /// Why this subscription was canceled.
        /// One of: <c>canceled_by_retention_policy</c>, <c>cancellation_requested</c>,
        /// <c>payment_disputed</c>, or <c>payment_failed</c>.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
