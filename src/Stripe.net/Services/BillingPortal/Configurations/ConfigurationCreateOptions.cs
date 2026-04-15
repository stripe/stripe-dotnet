// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfigurationCreateOptions : BaseOptions, IHasMetadata
    {
        private string defaultReturnUrl;
        private string name;

        /// <summary>
        /// The business information shown to customers in the portal.
        /// </summary>
        [JsonProperty("business_profile")]
        [STJS.JsonPropertyName("business_profile")]
        public ConfigurationBusinessProfileOptions BusinessProfile { get; set; }

        /// <summary>
        /// The default URL to redirect customers to when they click on the portal's link to return
        /// to your website. This can be <a
        /// href="https://docs.stripe.com/api/customer_portal/sessions/create#create_portal_session-return_url">overriden</a>
        /// when creating the session.
        /// </summary>
        [JsonProperty("default_return_url", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("default_return_url")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string DefaultReturnUrl
        {
            get => this.defaultReturnUrl;
            set
            {
                this.defaultReturnUrl = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Information about the features available in the portal.
        /// </summary>
        [JsonProperty("features")]
        [STJS.JsonPropertyName("features")]
        public ConfigurationFeaturesOptions Features { get; set; }

        /// <summary>
        /// The hosted login page for this configuration. Learn more about the portal login page in
        /// our <a
        /// href="https://stripe.com/docs/billing/subscriptions/integrating-customer-portal#share">integration
        /// docs</a>.
        /// </summary>
        [JsonProperty("login_page")]
        [STJS.JsonPropertyName("login_page")]
        public ConfigurationLoginPageOptions LoginPage { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The name of the configuration.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("name")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string Name
        {
            get => this.name;
            set
            {
                this.name = value;
                this.SetTracker.Track();
            }
        }
    }
}
