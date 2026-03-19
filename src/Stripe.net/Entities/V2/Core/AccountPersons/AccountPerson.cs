// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A Person represents an individual associated with an Account's identity (for example, an
    /// owner, director, executive, or representative). Use Persons to provide and update
    /// identity information for verification and compliance.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountPerson : StripeEntity<AccountPerson>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the Person.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The account ID which the individual belongs to.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Additional addresses associated with the person.
        /// </summary>
        [JsonProperty("additional_addresses")]
        [STJS.JsonPropertyName("additional_addresses")]
        public List<AccountPersonAdditionalAddress> AdditionalAddresses { get; set; }

        /// <summary>
        /// Additional names (e.g. aliases) associated with the person.
        /// </summary>
        [JsonProperty("additional_names")]
        [STJS.JsonPropertyName("additional_names")]
        public List<AccountPersonAdditionalName> AdditionalNames { get; set; }

        /// <summary>
        /// Attestations of accepted terms of service agreements.
        /// </summary>
        [JsonProperty("additional_terms_of_service")]
        [STJS.JsonPropertyName("additional_terms_of_service")]
        public AccountPersonAdditionalTermsOfService AdditionalTermsOfService { get; set; }

        /// <summary>
        /// The person's residential address.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public AccountPersonAddress Address { get; set; }

        /// <summary>
        /// Time at which the object was created. Represented as a RFC 3339 date &amp; time UTC
        /// value in millisecond precision, for example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The person's date of birth.
        /// </summary>
        [JsonProperty("date_of_birth")]
        [STJS.JsonPropertyName("date_of_birth")]
        public AccountPersonDateOfBirth DateOfBirth { get; set; }

        /// <summary>
        /// Documents that may be submitted to satisfy various informational requests.
        /// </summary>
        [JsonProperty("documents")]
        [STJS.JsonPropertyName("documents")]
        public AccountPersonDocuments Documents { get; set; }

        /// <summary>
        /// The person's email address.
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
        public List<AccountPersonIdNumber> IdNumbers { get; set; }

        /// <summary>
        /// The person's gender (International regulations require either "male" or "female").
        /// One of: <c>female</c>, or <c>male</c>.
        /// </summary>
        [JsonProperty("legal_gender")]
        [STJS.JsonPropertyName("legal_gender")]
        public string LegalGender { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The countries where the person is a national. Two-letter country code (<a
        /// href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</a>).
        /// </summary>
        [JsonProperty("nationalities")]
        [STJS.JsonPropertyName("nationalities")]
        public List<string> Nationalities { get; set; }

        /// <summary>
        /// The person's phone number.
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
        public AccountPersonRelationship Relationship { get; set; }

        /// <summary>
        /// The script addresses (e.g., non-Latin characters) associated with the person.
        /// </summary>
        [JsonProperty("script_addresses")]
        [STJS.JsonPropertyName("script_addresses")]
        public AccountPersonScriptAddresses ScriptAddresses { get; set; }

        /// <summary>
        /// The script names (e.g. non-Latin characters) associated with the person.
        /// </summary>
        [JsonProperty("script_names")]
        [STJS.JsonPropertyName("script_names")]
        public AccountPersonScriptNames ScriptNames { get; set; }

        /// <summary>
        /// The person's last name.
        /// </summary>
        [JsonProperty("surname")]
        [STJS.JsonPropertyName("surname")]
        public string Surname { get; set; }

        /// <summary>
        /// Time at which the object was last updated. Represented as a RFC 3339 date &amp; time UTC
        /// value in millisecond precision, for example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("updated")]
        [STJS.JsonPropertyName("updated")]
        public DateTime Updated { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
