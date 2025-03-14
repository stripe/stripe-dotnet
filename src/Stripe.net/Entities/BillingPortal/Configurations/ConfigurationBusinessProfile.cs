// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationBusinessProfile : StripeEntity<ConfigurationBusinessProfile>
    {
        /// <summary>
        /// The messaging shown to customers in the portal.
        /// </summary>
        [JsonProperty("headline")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("headline")]
#endif
        public string Headline { get; set; }

        /// <summary>
        /// A link to the business’s publicly available privacy policy.
        /// </summary>
        [JsonProperty("privacy_policy_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("privacy_policy_url")]
#endif
        public string PrivacyPolicyUrl { get; set; }

        /// <summary>
        /// A link to the business’s publicly available terms of service.
        /// </summary>
        [JsonProperty("terms_of_service_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("terms_of_service_url")]
#endif
        public string TermsOfServiceUrl { get; set; }
    }
}
