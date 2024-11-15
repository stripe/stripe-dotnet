// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The business information shown to customers in the portal.
        /// </summary>
        [JsonProperty("business_profile")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("business_profile")]
#endif

        public ConfigurationBusinessProfileOptions BusinessProfile { get; set; }

        /// <summary>
        /// The default URL to redirect customers to when they click on the portal's link to return
        /// to your website. This can be <a
        /// href="https://stripe.com/docs/api/customer_portal/sessions/create#create_portal_session-return_url">overriden</a>
        /// when creating the session.
        /// </summary>
        [JsonProperty("default_return_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_return_url")]
#endif

        public string DefaultReturnUrl { get; set; }

        /// <summary>
        /// Information about the features available in the portal.
        /// </summary>
        [JsonProperty("features")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("features")]
#endif

        public ConfigurationFeaturesOptions Features { get; set; }

        /// <summary>
        /// The hosted login page for this configuration. Learn more about the portal login page in
        /// our <a
        /// href="https://stripe.com/docs/billing/subscriptions/integrating-customer-portal#share">integration
        /// docs</a>.
        /// </summary>
        [JsonProperty("login_page")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("login_page")]
#endif

        public ConfigurationLoginPageOptions LoginPage { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif

        public Dictionary<string, string> Metadata { get; set; }
    }
}
