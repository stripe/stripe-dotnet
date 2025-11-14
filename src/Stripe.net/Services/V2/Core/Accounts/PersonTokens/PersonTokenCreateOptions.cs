// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Accounts
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PersonTokenCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Additional addresses associated with the person.
        /// </summary>
        [JsonProperty("additional_addresses")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("additional_addresses")]
#endif
        public List<PersonTokenCreateAdditionalAddressOptions> AdditionalAddresses { get; set; }

        /// <summary>
        /// Additional names (e.g. aliases) associated with the person.
        /// </summary>
        [JsonProperty("additional_names")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("additional_names")]
#endif
        public List<PersonTokenCreateAdditionalNameOptions> AdditionalNames { get; set; }

        /// <summary>
        /// Attestations of accepted terms of service agreements.
        /// </summary>
        [JsonProperty("additional_terms_of_service")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("additional_terms_of_service")]
#endif
        public PersonTokenCreateAdditionalTermsOfServiceOptions AdditionalTermsOfService { get; set; }

        /// <summary>
        /// The person's residential address.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public AddressJapanOptions Address { get; set; }

        /// <summary>
        /// The person's date of birth.
        /// </summary>
        [JsonProperty("date_of_birth")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("date_of_birth")]
#endif
        public PersonTokenCreateDateOfBirthOptions DateOfBirth { get; set; }

        /// <summary>
        /// Documents that may be submitted to satisfy various informational requests.
        /// </summary>
        [JsonProperty("documents")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("documents")]
#endif
        public PersonTokenCreateDocumentsOptions Documents { get; set; }

        /// <summary>
        /// Email.
        /// </summary>
        [JsonProperty("email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email")]
#endif
        public string Email { get; set; }

        /// <summary>
        /// The person's first name.
        /// </summary>
        [JsonProperty("given_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("given_name")]
#endif
        public string GivenName { get; set; }

        /// <summary>
        /// The identification numbers (e.g., SSN) associated with the person.
        /// </summary>
        [JsonProperty("id_numbers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id_numbers")]
#endif
        public List<PersonTokenCreateIdNumberOptions> IdNumbers { get; set; }

        /// <summary>
        /// The person's gender (International regulations require either "male" or "female").
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
        /// The nationalities (countries) this person is associated with.
        /// </summary>
        [JsonProperty("nationalities")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("nationalities")]
#endif
        public List<string> Nationalities { get; set; }

        /// <summary>
        /// The phone number for this person.
        /// </summary>
        [JsonProperty("phone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone")]
#endif
        public string Phone { get; set; }

        /// <summary>
        /// The person's political exposure.
        /// One of: <c>existing</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("political_exposure")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("political_exposure")]
#endif
        public string PoliticalExposure { get; set; }

        /// <summary>
        /// The relationship that this person has with the Account's business or legal entity.
        /// </summary>
        [JsonProperty("relationship")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("relationship")]
#endif
        public PersonTokenCreateRelationshipOptions Relationship { get; set; }

        /// <summary>
        /// The script addresses (e.g., non-Latin characters) associated with the person.
        /// </summary>
        [JsonProperty("script_addresses")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("script_addresses")]
#endif
        public PersonTokenCreateScriptAddressesOptions ScriptAddresses { get; set; }

        /// <summary>
        /// The script names (e.g. non-Latin characters) associated with the person.
        /// </summary>
        [JsonProperty("script_names")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("script_names")]
#endif
        public PersonTokenCreateScriptNamesOptions ScriptNames { get; set; }

        /// <summary>
        /// The person's last name.
        /// </summary>
        [JsonProperty("surname")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("surname")]
#endif
        public string Surname { get; set; }
    }
}
