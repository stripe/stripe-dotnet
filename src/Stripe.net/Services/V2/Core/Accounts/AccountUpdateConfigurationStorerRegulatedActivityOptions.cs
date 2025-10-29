// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateConfigurationStorerRegulatedActivityOptions : INestedOptions
    {
        /// <summary>
        /// A detailed description of the regulated activities the business is licensed to conduct.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// The license number or registration number assigned by the business's primary regulator.
        /// </summary>
        [JsonProperty("license_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("license_number")]
#endif
        public string LicenseNumber { get; set; }

        /// <summary>
        /// The country of the primary regulatory authority that oversees the business's regulated
        /// activities.
        /// </summary>
        [JsonProperty("primary_regulatory_authority_country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("primary_regulatory_authority_country")]
#endif
        public string PrimaryRegulatoryAuthorityCountry { get; set; }

        /// <summary>
        /// The name of the primary regulatory authority that oversees the business's regulated
        /// activities.
        /// </summary>
        [JsonProperty("primary_regulatory_authority_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("primary_regulatory_authority_name")]
#endif
        public string PrimaryRegulatoryAuthorityName { get; set; }
    }
}
