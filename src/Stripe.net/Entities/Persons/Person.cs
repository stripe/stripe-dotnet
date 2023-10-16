// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// This is an object representing a person associated with a Stripe account.
    ///
    /// A platform cannot access a Standard or Express account's persons after the account
    /// starts onboarding, such as after generating an account link for the account. See the <a
    /// href="https://stripe.com/docs/connect/standard-accounts">Standard onboarding</a> or <a
    /// href="https://stripe.com/docs/connect/express-accounts">Express onboarding
    /// documentation</a> for information about platform prefilling and account onboarding
    /// steps.
    ///
    /// Related guide: <a
    /// href="https://stripe.com/docs/connect/handling-api-verification#person-information">Handling
    /// identity verification with the API</a>.
    /// </summary>
    public class Person : StripeEntity<Person>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// The account the person is associated with.
        /// </summary>
        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("additional_tos_acceptances")]
        public PersonAdditionalTosAcceptances AdditionalTosAcceptances { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        /// <summary>
        /// The Kana variation of the person's address (Japan only).
        /// </summary>
        [JsonProperty("address_kana")]
        public AddressJapan AddressKana { get; set; }

        /// <summary>
        /// The Kanji variation of the person's address (Japan only).
        /// </summary>
        [JsonProperty("address_kanji")]
        public AddressJapan AddressKanji { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        [JsonProperty("dob")]
        public Dob Dob { get; set; }

        /// <summary>
        /// The person's email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The person's first name.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The Kana variation of the person's first name (Japan only).
        /// </summary>
        [JsonProperty("first_name_kana")]
        public string FirstNameKana { get; set; }

        /// <summary>
        /// The Kanji variation of the person's first name (Japan only).
        /// </summary>
        [JsonProperty("first_name_kanji")]
        public string FirstNameKanji { get; set; }

        /// <summary>
        /// A list of alternate names or aliases that the person is known by.
        /// </summary>
        [JsonProperty("full_name_aliases")]
        public List<string> FullNameAliases { get; set; }

        /// <summary>
        /// Information about the <a
        /// href="https://stripe.com/docs/connect/custom-accounts/future-requirements">upcoming new
        /// requirements for this person</a>, including what information needs to be collected, and
        /// by when.
        /// </summary>
        [JsonProperty("future_requirements")]
        public PersonFutureRequirements FutureRequirements { get; set; }

        /// <summary>
        /// The person's gender (International regulations require either "male" or "female").
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// Whether the person's <c>id_number</c> was provided. True if either the full ID number
        /// was provided or if only the required part of the ID number was provided (ex. last four
        /// of an individual's SSN for the US indicated by <c>ssn_last_4_provided</c>).
        /// </summary>
        [JsonProperty("id_number_provided")]
        public bool IdNumberProvided { get; set; }

        /// <summary>
        /// Whether the person's <c>id_number_secondary</c> was provided.
        /// </summary>
        [JsonProperty("id_number_secondary_provided")]
        public bool IdNumberSecondaryProvided { get; set; }

        /// <summary>
        /// The person's last name.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// The Kana variation of the person's last name (Japan only).
        /// </summary>
        [JsonProperty("last_name_kana")]
        public string LastNameKana { get; set; }

        /// <summary>
        /// The Kanji variation of the person's last name (Japan only).
        /// </summary>
        [JsonProperty("last_name_kanji")]
        public string LastNameKanji { get; set; }

        /// <summary>
        /// The person's maiden name.
        /// </summary>
        [JsonProperty("maiden_name")]
        public string MaidenName { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The country where the person is a national.
        /// </summary>
        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// The person's phone number.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Indicates if the person or any of their representatives, family members, or other
        /// closely related persons, declares that they hold or have held an important public job or
        /// function, in any jurisdiction.
        /// One of: <c>existing</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("political_exposure")]
        public string PoliticalExposure { get; set; }

        [JsonProperty("registered_address")]
        public Address RegisteredAddress { get; set; }

        [JsonProperty("relationship")]
        public PersonRelationship Relationship { get; set; }

        /// <summary>
        /// Information about the requirements for this person, including what information needs to
        /// be collected, and by when.
        /// </summary>
        [JsonProperty("requirements")]
        public PersonRequirements Requirements { get; set; }

        /// <summary>
        /// Whether the last four digits of the person's Social Security number have been provided
        /// (U.S. only).
        /// </summary>
        [JsonProperty("ssn_last_4_provided")]
        public bool SsnLast4Provided { get; set; }

        [JsonProperty("verification")]
        public PersonVerification Verification { get; set; }
    }
}
