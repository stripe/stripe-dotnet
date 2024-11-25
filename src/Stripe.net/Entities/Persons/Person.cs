// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// This is an object representing a person associated with a Stripe account.
    ///
    /// A platform cannot access a person for an account where <a
    /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">account.controller.requirement_collection</a>
    /// is <c>stripe</c>, which includes Standard and Express accounts, after creating an
    /// Account Link or Account Session to start Connect onboarding.
    ///
    /// See the <a href="https://stripe.com/connect/standard-accounts">Standard onboarding</a>
    /// or <a href="https://stripe.com/connect/express-accounts">Express onboarding</a>
    /// documentation for information about prefilling information and account onboarding steps.
    /// Learn more about <a
    /// href="https://stripe.com/connect/handling-api-verification#person-information">handling
    /// identity verification with the API</a>.
    /// </summary>
    public class Person : StripeEntity<Person>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif

        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif

        public string Object { get; set; }

        /// <summary>
        /// The account the person is associated with.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif

        public string Account { get; set; }

        [JsonProperty("additional_tos_acceptances")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("additional_tos_acceptances")]
#endif

        public PersonAdditionalTosAcceptances AdditionalTosAcceptances { get; set; }

        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif

        public Address Address { get; set; }

        /// <summary>
        /// The Kana variation of the person's address (Japan only).
        /// </summary>
        [JsonProperty("address_kana")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_kana")]
#endif

        public AddressJapan AddressKana { get; set; }

        /// <summary>
        /// The Kanji variation of the person's address (Japan only).
        /// </summary>
        [JsonProperty("address_kanji")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_kanji")]
#endif

        public AddressJapan AddressKanji { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("deleted")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
#endif

        public bool? Deleted { get; set; }

        [JsonProperty("dob")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dob")]
#endif

        public Dob Dob { get; set; }

        /// <summary>
        /// The person's email address.
        /// </summary>
        [JsonProperty("email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email")]
#endif

        public string Email { get; set; }

        /// <summary>
        /// The person's first name.
        /// </summary>
        [JsonProperty("first_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("first_name")]
#endif

        public string FirstName { get; set; }

        /// <summary>
        /// The Kana variation of the person's first name (Japan only).
        /// </summary>
        [JsonProperty("first_name_kana")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("first_name_kana")]
#endif

        public string FirstNameKana { get; set; }

        /// <summary>
        /// The Kanji variation of the person's first name (Japan only).
        /// </summary>
        [JsonProperty("first_name_kanji")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("first_name_kanji")]
#endif

        public string FirstNameKanji { get; set; }

        /// <summary>
        /// A list of alternate names or aliases that the person is known by.
        /// </summary>
        [JsonProperty("full_name_aliases")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("full_name_aliases")]
#endif

        public List<string> FullNameAliases { get; set; }

        /// <summary>
        /// Information about the <a
        /// href="https://stripe.com/docs/connect/custom-accounts/future-requirements">upcoming new
        /// requirements for this person</a>, including what information needs to be collected, and
        /// by when.
        /// </summary>
        [JsonProperty("future_requirements")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("future_requirements")]
#endif

        public PersonFutureRequirements FutureRequirements { get; set; }

        /// <summary>
        /// The person's gender.
        /// </summary>
        [JsonProperty("gender")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gender")]
#endif

        public string Gender { get; set; }

        /// <summary>
        /// Whether the person's <c>id_number</c> was provided. True if either the full ID number
        /// was provided or if only the required part of the ID number was provided (ex. last four
        /// of an individual's SSN for the US indicated by <c>ssn_last_4_provided</c>).
        /// </summary>
        [JsonProperty("id_number_provided")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id_number_provided")]
#endif

        public bool IdNumberProvided { get; set; }

        /// <summary>
        /// Whether the person's <c>id_number_secondary</c> was provided.
        /// </summary>
        [JsonProperty("id_number_secondary_provided")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id_number_secondary_provided")]
#endif

        public bool IdNumberSecondaryProvided { get; set; }

        /// <summary>
        /// The person's last name.
        /// </summary>
        [JsonProperty("last_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last_name")]
#endif

        public string LastName { get; set; }

        /// <summary>
        /// The Kana variation of the person's last name (Japan only).
        /// </summary>
        [JsonProperty("last_name_kana")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last_name_kana")]
#endif

        public string LastNameKana { get; set; }

        /// <summary>
        /// The Kanji variation of the person's last name (Japan only).
        /// </summary>
        [JsonProperty("last_name_kanji")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last_name_kanji")]
#endif

        public string LastNameKanji { get; set; }

        /// <summary>
        /// The person's maiden name.
        /// </summary>
        [JsonProperty("maiden_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("maiden_name")]
#endif

        public string MaidenName { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif

        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The country where the person is a national.
        /// </summary>
        [JsonProperty("nationality")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("nationality")]
#endif

        public string Nationality { get; set; }

        /// <summary>
        /// The person's phone number.
        /// </summary>
        [JsonProperty("phone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone")]
#endif

        public string Phone { get; set; }

        /// <summary>
        /// Indicates if the person or any of their representatives, family members, or other
        /// closely related persons, declares that they hold or have held an important public job or
        /// function, in any jurisdiction.
        /// One of: <c>existing</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("political_exposure")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("political_exposure")]
#endif

        public string PoliticalExposure { get; set; }

        [JsonProperty("registered_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("registered_address")]
#endif

        public Address RegisteredAddress { get; set; }

        [JsonProperty("relationship")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("relationship")]
#endif

        public PersonRelationship Relationship { get; set; }

        /// <summary>
        /// Information about the requirements for this person, including what information needs to
        /// be collected, and by when.
        /// </summary>
        [JsonProperty("requirements")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requirements")]
#endif

        public PersonRequirements Requirements { get; set; }

        /// <summary>
        /// Whether the last four digits of the person's Social Security number have been provided
        /// (U.S. only).
        /// </summary>
        [JsonProperty("ssn_last_4_provided")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ssn_last_4_provided")]
#endif

        public bool SsnLast4Provided { get; set; }

        [JsonProperty("verification")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verification")]
#endif

        public PersonVerification Verification { get; set; }
    }
}
