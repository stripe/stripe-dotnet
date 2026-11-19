// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ProductMarketingFeatureOptions : INestedOptions, IHasSetTracking
    {
        private string lossMessage;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Optional text that describes what a customer loses by canceling, shown for this
        /// marketing feature in the Customer Portal cancellation flow. Up to 80 characters long. If
        /// you omit it when you update <c>marketing_features</c>, Stripe keeps the message stored
        /// for the feature with the same name. Duplicate names are matched in order. Set it to an
        /// empty string to remove the override. When no override is stored, eligible cancellation
        /// flows use the marketing feature name. A renamed feature is treated as a new feature, so
        /// send the message again to keep it.
        /// </summary>
        [JsonProperty("loss_message", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("loss_message")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string LossMessage
        {
            get => this.lossMessage;
            set
            {
                this.lossMessage = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The marketing feature name. Up to 80 characters long.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
