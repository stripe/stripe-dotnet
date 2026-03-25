// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Accounts
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PersonTokenCreateOptions : BaseOptions, IHasMetadata
    {
        private Dictionary<string, string> metadata;

        /// <summary>
        /// Additional addresses associated with the person.
        /// </summary>
        [JsonProperty("additional_addresses")]
        [STJS.JsonPropertyName("additional_addresses")]
        public List<PersonTokenCreateAdditionalAddressOptions> AdditionalAddresses { get; set; }

        /// <summary>
        /// Additional names (e.g. aliases) associated with the person.
        /// </summary>
        [JsonProperty("additional_names")]
        [STJS.JsonPropertyName("additional_names")]
        public List<PersonTokenCreateAdditionalNameOptions> AdditionalNames { get; set; }

        /// <summary>
        /// Attestations of accepted terms of service agreements.
        /// </summary>
        [JsonProperty("additional_terms_of_service")]
        [STJS.JsonPropertyName("additional_terms_of_service")]
        public PersonTokenCreateAdditionalTermsOfServiceOptions AdditionalTermsOfService { get; set; }

        /// <summary>
        /// The person's residential address.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public AddressJapanOptions Address { get; set; }

        /// <summary>
        /// The person's date of birth.
        /// </summary>
        [JsonProperty("date_of_birth")]
        [STJS.JsonPropertyName("date_of_birth")]
        public PersonTokenCreateDateOfBirthOptions DateOfBirth { get; set; }

        /// <summary>
        /// Documents that may be submitted to satisfy various informational requests.
        /// </summary>
        [JsonProperty("documents")]
        [STJS.JsonPropertyName("documents")]
        public PersonTokenCreateDocumentsOptions Documents { get; set; }

        /// <summary>
        /// Email.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// The person's first name.
        /// </summary>
        [JsonProperty("given_name")]
        [STJS.JsonPropertyName("given_name")]
        public string GivenName { get; set; }

        /// <summary>
        /// The identification numbers (e.g., SSN) associated with the person.
        /// </summary>
        [JsonProperty("id_numbers")]
        [STJS.JsonPropertyName("id_numbers")]
        public List<PersonTokenCreateIdNumberOptions> IdNumbers { get; set; }

        /// <summary>
        /// The person's gender (International regulations require either "male" or "female").
        /// One of: <c>female</c>, or <c>male</c>.
        /// </summary>
        [JsonProperty("legal_gender")]
        [STJS.JsonPropertyName("legal_gender")]
        public string LegalGender { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        [STJS.JsonConverter(typeof(STJNullPreservingDictionaryConverter))]
        public Dictionary<string, string> Metadata
        {
            get => this.metadata;
            set
            {
                this.metadata = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The nationalities (countries) this person is associated with.
        /// </summary>
        [JsonProperty("nationalities")]
        [STJS.JsonPropertyName("nationalities")]
        public List<string> Nationalities { get; set; }

        /// <summary>
        /// The phone number for this person.
        /// </summary>
        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The person's political exposure.
        /// One of: <c>existing</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("political_exposure")]
        [STJS.JsonPropertyName("political_exposure")]
        public string PoliticalExposure { get; set; }

        /// <summary>
        /// The relationship that this person has with the Account's business or legal entity.
        /// </summary>
        [JsonProperty("relationship")]
        [STJS.JsonPropertyName("relationship")]
        public PersonTokenCreateRelationshipOptions Relationship { get; set; }

        /// <summary>
        /// The script addresses (e.g., non-Latin characters) associated with the person.
        /// </summary>
        [JsonProperty("script_addresses")]
        [STJS.JsonPropertyName("script_addresses")]
        public PersonTokenCreateScriptAddressesOptions ScriptAddresses { get; set; }

        /// <summary>
        /// The script names (e.g. non-Latin characters) associated with the person.
        /// </summary>
        [JsonProperty("script_names")]
        [STJS.JsonPropertyName("script_names")]
        public PersonTokenCreateScriptNamesOptions ScriptNames { get; set; }

        /// <summary>
        /// The person's last name.
        /// </summary>
        [JsonProperty("surname")]
        [STJS.JsonPropertyName("surname")]
        public string Surname { get; set; }
    }
}
