// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfigurationFeaturesCustomerUpdateOptions : INestedOptions, IHasSetTracking
    {
        private List<string> allowedUpdates;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// The types of customer updates that are supported. When empty, customers are not
        /// updateable.
        /// One of: <c>address</c>, <c>email</c>, <c>name</c>, <c>phone</c>, <c>shipping</c>, or
        /// <c>tax_id</c>.
        /// </summary>
        [JsonProperty("allowed_updates", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("allowed_updates")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<string> AllowedUpdates
        {
            get => this.allowedUpdates;
            set
            {
                this.allowedUpdates = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Whether the feature is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
