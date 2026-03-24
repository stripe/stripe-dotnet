// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationStorerRegulatedActivity : StripeEntity<AccountConfigurationStorerRegulatedActivity>
    {
        /// <summary>
        /// A detailed description of the regulated activities the business is licensed to conduct.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The license number or registration number assigned by the business's primary regulator.
        /// </summary>
        [JsonProperty("license_number")]
        [STJS.JsonPropertyName("license_number")]
        public string LicenseNumber { get; set; }

        /// <summary>
        /// The country of the primary regulatory authority that oversees the business's regulated
        /// activities.
        /// </summary>
        [JsonProperty("primary_regulatory_authority_country")]
        [STJS.JsonPropertyName("primary_regulatory_authority_country")]
        public string PrimaryRegulatoryAuthorityCountry { get; set; }

        /// <summary>
        /// The name of the primary regulatory authority that oversees the business's regulated
        /// activities.
        /// </summary>
        [JsonProperty("primary_regulatory_authority_name")]
        [STJS.JsonPropertyName("primary_regulatory_authority_name")]
        public string PrimaryRegulatoryAuthorityName { get; set; }
    }
}
