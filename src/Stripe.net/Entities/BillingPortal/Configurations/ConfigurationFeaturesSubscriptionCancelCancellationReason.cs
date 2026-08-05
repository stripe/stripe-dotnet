// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConfigurationFeaturesSubscriptionCancelCancellationReason : StripeEntity<ConfigurationFeaturesSubscriptionCancelCancellationReason>
    {
        /// <summary>
        /// Whether the feature is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        #region Expandable FeedbackOptions

        /// <summary>
        /// (IDs of the FeedbackOptions)
        /// The IDs of custom feedback options configured for this cancellation reason.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public List<string> FeedbackOptionIds
        {
            get => this.InternalFeedbackOptions?.Select((x) => x.Id).ToList();
            set => this.InternalFeedbackOptions = SetExpandableArrayIds<Billing.FeedbackOptions>(value);
        }

        /// <summary>
        /// (Expanded)
        /// The IDs of custom feedback options configured for this cancellation reason.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public List<Billing.FeedbackOptions> FeedbackOptions
        {
            get => this.InternalFeedbackOptions?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalFeedbackOptions = SetExpandableArrayObjects(value);
        }

        [JsonProperty("feedback_options", ItemConverterType = typeof(ExpandableFieldConverter<Billing.FeedbackOptions>))]
        [STJS.JsonPropertyName("feedback_options")]
        internal List<ExpandableField<Billing.FeedbackOptions>> InternalFeedbackOptions { get; set; }
        #endregion

        /// <summary>
        /// Which cancellation reasons will be given as options to the customer.
        /// One of: <c>customer_service</c>, <c>low_quality</c>, <c>missing_features</c>,
        /// <c>other</c>, <c>switched_service</c>, <c>too_complex</c>, <c>too_expensive</c>, or
        /// <c>unused</c>.
        /// </summary>
        [JsonProperty("options")]
        [STJS.JsonPropertyName("options")]
        public List<string> Options { get; set; }
    }
}
