// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfigurationBusinessProfileOptions : INestedOptions, IHasSetTracking
    {
        private string headline;
        private string privacyPolicyUrl;
        private string termsOfServiceUrl;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// The messaging shown to customers in the portal.
        /// </summary>
        [JsonProperty("headline", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("headline")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string Headline
        {
            get => this.headline;
            set
            {
                this.headline = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// A link to the business’s publicly available privacy policy.
        /// </summary>
        [JsonProperty("privacy_policy_url", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("privacy_policy_url")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string PrivacyPolicyUrl
        {
            get => this.privacyPolicyUrl;
            set
            {
                this.privacyPolicyUrl = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// A link to the business’s publicly available terms of service.
        /// </summary>
        [JsonProperty("terms_of_service_url", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("terms_of_service_url")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string TermsOfServiceUrl
        {
            get => this.termsOfServiceUrl;
            set
            {
                this.termsOfServiceUrl = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
