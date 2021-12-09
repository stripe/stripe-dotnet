// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ConfigurationUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Whether the configuration is active and can be used to create portal sessions.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// The business information shown to customers in the portal.
        /// </summary>
        [JsonProperty("business_profile")]
        public ConfigurationBusinessProfileOptions BusinessProfile { get; set; }

        /// <summary>
        /// The default URL to redirect customers to when they click on the portal's link to return
        /// to your website. This can be <a
        /// href="https://stripe.com/docs/api/customer_portal/sessions/create#create_portal_session-return_url">overriden</a>
        /// when creating the session.
        /// </summary>
        [JsonProperty("default_return_url")]
        public string DefaultReturnUrl { get; set; }

        /// <summary>
        /// Information about the features available in the portal.
        /// </summary>
        [JsonProperty("features")]
        public ConfigurationFeaturesOptions Features { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
