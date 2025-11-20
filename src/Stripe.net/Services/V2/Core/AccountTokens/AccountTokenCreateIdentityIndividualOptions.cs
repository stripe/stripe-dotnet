// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountTokenCreateIdentityIndividualOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// Additional addresses associated with the individual.
        /// </summary>
        [JsonProperty("additional_addresses")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("additional_addresses")]
#endif
        public List<AccountTokenCreateIdentityIndividualAdditionalAddressOptions> AdditionalAddresses { get; set; }

        /// <summary>
        /// Additional names (e.g. aliases) associated with the individual.
        /// </summary>
        [JsonProperty("additional_names")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("additional_names")]
#endif
        public List<AccountTokenCreateIdentityIndividualAdditionalNameOptions> AdditionalNames { get; set; }

        /// <summary>
        /// The individual's residential address.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public AddressJapanOptions Address { get; set; }

        /// <summary>
        /// The individual's date of birth.
        /// </summary>
        [JsonProperty("date_of_birth")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("date_of_birth")]
#endif
        public AccountTokenCreateIdentityIndividualDateOfBirthOptions DateOfBirth { get; set; }

        /// <summary>
        /// Documents that may be submitted to satisfy various informational requests.
        /// </summary>
        [JsonProperty("documents")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("documents")]
#endif
        public AccountTokenCreateIdentityIndividualDocumentsOptions Documents { get; set; }

        /// <summary>
        /// The individual's email address.
        /// </summary>
        [JsonProperty("email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email")]
#endif
        public string Email { get; set; }

        /// <summary>
        /// The individual's first name.
        /// </summary>
        [JsonProperty("given_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("given_name")]
#endif
        public string GivenName { get; set; }

        /// <summary>
        /// The identification numbers (e.g., SSN) associated with the individual.
        /// </summary>
        [JsonProperty("id_numbers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id_numbers")]
#endif
        public List<AccountTokenCreateIdentityIndividualIdNumberOptions> IdNumbers { get; set; }

        /// <summary>
        /// The individual's gender (International regulations require either "male" or "female").
        /// One of: <c>female</c>, or <c>male</c>.
        /// </summary>
        [JsonProperty("legal_gender")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("legal_gender")]
#endif
        public string LegalGender { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The countries where the individual is a national. Two-letter country code (<a
        /// href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</a>).
        /// </summary>
        [JsonProperty("nationalities")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("nationalities")]
#endif
        public List<string> Nationalities { get; set; }

        /// <summary>
        /// The individual's phone number.
        /// </summary>
        [JsonProperty("phone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone")]
#endif
        public string Phone { get; set; }

        /// <summary>
        /// The individual's political exposure.
        /// One of: <c>existing</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("political_exposure")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("political_exposure")]
#endif
        public string PoliticalExposure { get; set; }

        /// <summary>
        /// The relationship that this individual has with the account's identity.
        /// </summary>
        [JsonProperty("relationship")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("relationship")]
#endif
        public AccountTokenCreateIdentityIndividualRelationshipOptions Relationship { get; set; }

        /// <summary>
        /// The script addresses (e.g., non-Latin characters) associated with the individual.
        /// </summary>
        [JsonProperty("script_addresses")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("script_addresses")]
#endif
        public AccountTokenCreateIdentityIndividualScriptAddressesOptions ScriptAddresses { get; set; }

        /// <summary>
        /// The individuals primary name in non latin script.
        /// </summary>
        [JsonProperty("script_names")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("script_names")]
#endif
        public AccountTokenCreateIdentityIndividualScriptNamesOptions ScriptNames { get; set; }

        /// <summary>
        /// The individual's last name.
        /// </summary>
        [JsonProperty("surname")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("surname")]
#endif
        public string Surname { get; set; }
    }
}
