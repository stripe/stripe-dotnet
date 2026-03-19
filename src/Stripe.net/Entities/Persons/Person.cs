// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// This is an object representing a person associated with a Stripe account.
    ///
    /// A platform can only access a subset of data in a person for an account where <a
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
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Person : StripeEntity<Person>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The account the person is associated with.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        [JsonProperty("additional_tos_acceptances")]
        [STJS.JsonPropertyName("additional_tos_acceptances")]
        public PersonAdditionalTosAcceptances AdditionalTosAcceptances { get; set; }

        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public Address Address { get; set; }

        /// <summary>
        /// The Kana variation of the person's address (Japan only).
        /// </summary>
        [JsonProperty("address_kana")]
        [STJS.JsonPropertyName("address_kana")]
        public AddressJapan AddressKana { get; set; }

        /// <summary>
        /// The Kanji variation of the person's address (Japan only).
        /// </summary>
        [JsonProperty("address_kanji")]
        [STJS.JsonPropertyName("address_kanji")]
        public AddressJapan AddressKanji { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("deleted")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public bool? Deleted { get; set; }

        [JsonProperty("dob")]
        [STJS.JsonPropertyName("dob")]
        public Dob Dob { get; set; }

        /// <summary>
        /// The person's email address. Also available for accounts where <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">controller.requirement_collection</a>
        /// is <c>stripe</c>.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// The person's first name. Also available for accounts where <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">controller.requirement_collection</a>
        /// is <c>stripe</c>.
        /// </summary>
        [JsonProperty("first_name")]
        [STJS.JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The Kana variation of the person's first name (Japan only). Also available for accounts
        /// where <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">controller.requirement_collection</a>
        /// is <c>stripe</c>.
        /// </summary>
        [JsonProperty("first_name_kana")]
        [STJS.JsonPropertyName("first_name_kana")]
        public string FirstNameKana { get; set; }

        /// <summary>
        /// The Kanji variation of the person's first name (Japan only). Also available for accounts
        /// where <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">controller.requirement_collection</a>
        /// is <c>stripe</c>.
        /// </summary>
        [JsonProperty("first_name_kanji")]
        [STJS.JsonPropertyName("first_name_kanji")]
        public string FirstNameKanji { get; set; }

        /// <summary>
        /// A list of alternate names or aliases that the person is known by. Also available for
        /// accounts where <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">controller.requirement_collection</a>
        /// is <c>stripe</c>.
        /// </summary>
        [JsonProperty("full_name_aliases")]
        [STJS.JsonPropertyName("full_name_aliases")]
        public List<string> FullNameAliases { get; set; }

        /// <summary>
        /// Information about the <a
        /// href="https://docs.stripe.com/connect/custom-accounts/future-requirements">upcoming new
        /// requirements for this person</a>, including what information needs to be collected, and
        /// by when.
        /// </summary>
        [JsonProperty("future_requirements")]
        [STJS.JsonPropertyName("future_requirements")]
        public PersonFutureRequirements FutureRequirements { get; set; }

        /// <summary>
        /// The person's gender.
        /// </summary>
        [JsonProperty("gender")]
        [STJS.JsonPropertyName("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// Whether the person's <c>id_number</c> was provided. True if either the full ID number
        /// was provided or if only the required part of the ID number was provided (ex. last four
        /// of an individual's SSN for the US indicated by <c>ssn_last_4_provided</c>).
        /// </summary>
        [JsonProperty("id_number_provided")]
        [STJS.JsonPropertyName("id_number_provided")]
        public bool IdNumberProvided { get; set; }

        /// <summary>
        /// Whether the person's <c>id_number_secondary</c> was provided.
        /// </summary>
        [JsonProperty("id_number_secondary_provided")]
        [STJS.JsonPropertyName("id_number_secondary_provided")]
        public bool IdNumberSecondaryProvided { get; set; }

        /// <summary>
        /// The person's last name. Also available for accounts where <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">controller.requirement_collection</a>
        /// is <c>stripe</c>.
        /// </summary>
        [JsonProperty("last_name")]
        [STJS.JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// The Kana variation of the person's last name (Japan only). Also available for accounts
        /// where <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">controller.requirement_collection</a>
        /// is <c>stripe</c>.
        /// </summary>
        [JsonProperty("last_name_kana")]
        [STJS.JsonPropertyName("last_name_kana")]
        public string LastNameKana { get; set; }

        /// <summary>
        /// The Kanji variation of the person's last name (Japan only). Also available for accounts
        /// where <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">controller.requirement_collection</a>
        /// is <c>stripe</c>.
        /// </summary>
        [JsonProperty("last_name_kanji")]
        [STJS.JsonPropertyName("last_name_kanji")]
        public string LastNameKanji { get; set; }

        /// <summary>
        /// The person's maiden name.
        /// </summary>
        [JsonProperty("maiden_name")]
        [STJS.JsonPropertyName("maiden_name")]
        public string MaidenName { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The country where the person is a national.
        /// </summary>
        [JsonProperty("nationality")]
        [STJS.JsonPropertyName("nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// The person's phone number.
        /// </summary>
        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Indicates if the person or any of their representatives, family members, or other
        /// closely related persons, declares that they hold or have held an important public job or
        /// function, in any jurisdiction.
        /// One of: <c>existing</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("political_exposure")]
        [STJS.JsonPropertyName("political_exposure")]
        public string PoliticalExposure { get; set; }

        [JsonProperty("registered_address")]
        [STJS.JsonPropertyName("registered_address")]
        public Address RegisteredAddress { get; set; }

        [JsonProperty("relationship")]
        [STJS.JsonPropertyName("relationship")]
        public PersonRelationship Relationship { get; set; }

        /// <summary>
        /// Information about the requirements for this person, including what information needs to
        /// be collected, and by when.
        /// </summary>
        [JsonProperty("requirements")]
        [STJS.JsonPropertyName("requirements")]
        public PersonRequirements Requirements { get; set; }

        /// <summary>
        /// Whether the last four digits of the person's Social Security number have been provided
        /// (U.S. only).
        /// </summary>
        [JsonProperty("ssn_last_4_provided")]
        [STJS.JsonPropertyName("ssn_last_4_provided")]
        public bool SsnLast4Provided { get; set; }

        /// <summary>
        /// Demographic data related to the person.
        /// </summary>
        [JsonProperty("us_cfpb_data")]
        [STJS.JsonPropertyName("us_cfpb_data")]
        public PersonUsCfpbData UsCfpbData { get; set; }

        [JsonProperty("verification")]
        [STJS.JsonPropertyName("verification")]
        public PersonVerification Verification { get; set; }
    }
}
