// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfigurationFeaturesSubscriptionCancelCancellationReasonOptions : INestedOptions, IHasSetTracking
    {
        private List<string> options;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Whether the feature is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Which cancellation reasons will be given as options to the customer.
        /// One of: <c>customer_service</c>, <c>low_quality</c>, <c>missing_features</c>,
        /// <c>other</c>, <c>switched_service</c>, <c>too_complex</c>, <c>too_expensive</c>, or
        /// <c>unused</c>.
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("options")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<string> Options
        {
            get => this.options;
            set
            {
                this.options = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
