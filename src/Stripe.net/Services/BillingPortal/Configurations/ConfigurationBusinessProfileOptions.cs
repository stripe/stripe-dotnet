// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class ConfigurationBusinessProfileOptions : INestedOptions
    {
        /// <summary>
        /// The messaging shown to customers in the portal.
        /// </summary>
        [JsonProperty("headline")]
        public string Headline { get; set; }

        /// <summary>
        /// A link to the business’s publicly available privacy policy.
        /// </summary>
        [JsonProperty("privacy_policy_url")]
        public string PrivacyPolicyUrl { get; set; }

        /// <summary>
        /// A link to the business’s publicly available terms of service.
        /// </summary>
        [JsonProperty("terms_of_service_url")]
        public string TermsOfServiceUrl { get; set; }
    }
}
