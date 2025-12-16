// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountIdentityIndividual : StripeEntity<AccountIdentityIndividual>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// The account ID which the individual belongs to.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public string Account { get; set; }

        /// <summary>
        /// Additional addresses associated with the individual.
        /// </summary>
        [JsonProperty("additional_addresses")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("additional_addresses")]
#endif
        public List<AccountIdentityIndividualAdditionalAddress> AdditionalAddresses { get; set; }

        /// <summary>
        /// Additional names (e.g. aliases) associated with the individual.
        /// </summary>
        [JsonProperty("additional_names")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("additional_names")]
#endif
        public List<AccountIdentityIndividualAdditionalName> AdditionalNames { get; set; }

        /// <summary>
        /// Terms of service acceptances.
        /// </summary>
        [JsonProperty("additional_terms_of_service")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("additional_terms_of_service")]
#endif
        public AccountIdentityIndividualAdditionalTermsOfService AdditionalTermsOfService { get; set; }

        /// <summary>
        /// The individual's residential address.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public AccountIdentityIndividualAddress Address { get; set; }

        /// <summary>
        /// Time at which the object was created. Represented as a RFC 3339 date &amp; time UTC
        /// value in millisecond precision, for example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The individual's date of birth.
        /// </summary>
        [JsonProperty("date_of_birth")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("date_of_birth")]
#endif
        public AccountIdentityIndividualDateOfBirth DateOfBirth { get; set; }

        /// <summary>
        /// Documents that may be submitted to satisfy various informational requests.
        /// </summary>
        [JsonProperty("documents")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("documents")]
#endif
        public AccountIdentityIndividualDocuments Documents { get; set; }

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
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// The identification numbers (e.g., SSN) associated with the individual.
        /// </summary>
        [JsonProperty("id_numbers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id_numbers")]
#endif
        public List<AccountIdentityIndividualIdNumber> IdNumbers { get; set; }

        /// <summary>
        /// The individual's gender (International regulations require either "male” or "female").
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
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The individual's phone number.
        /// </summary>
        [JsonProperty("phone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone")]
#endif
        public string Phone { get; set; }

        /// <summary>
        /// Indicates if the individual or any of their representatives, family members, or other
        /// closely related persons, declares that they hold or have held an important public job or
        /// function, in any jurisdiction.
        /// One of: <c>existing</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("political_exposure")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("political_exposure")]
#endif
        public string PoliticalExposure { get; set; }

        /// <summary>
        /// The relationship that this individual has with the Account's identity.
        /// </summary>
        [JsonProperty("relationship")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("relationship")]
#endif
        public AccountIdentityIndividualRelationship Relationship { get; set; }

        /// <summary>
        /// The script addresses (e.g., non-Latin characters) associated with the individual.
        /// </summary>
        [JsonProperty("script_addresses")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("script_addresses")]
#endif
        public AccountIdentityIndividualScriptAddresses ScriptAddresses { get; set; }

        /// <summary>
        /// The script names (e.g. non-Latin characters) associated with the individual.
        /// </summary>
        [JsonProperty("script_names")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("script_names")]
#endif
        public AccountIdentityIndividualScriptNames ScriptNames { get; set; }

        /// <summary>
        /// The individual's last name.
        /// </summary>
        [JsonProperty("surname")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("surname")]
#endif
        public string Surname { get; set; }

        /// <summary>
        /// Time at which the object was last updated.
        /// </summary>
        [JsonProperty("updated")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("updated")]
#endif
        public DateTime Updated { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
