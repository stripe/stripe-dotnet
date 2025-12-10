// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountPersonCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Details on the legal guardian's or authorizer's acceptance of the required Stripe
        /// agreements.
        /// </summary>
        [JsonProperty("additional_tos_acceptances")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("additional_tos_acceptances")]
#endif
        public AccountPersonAdditionalTosAcceptancesOptions AdditionalTosAcceptances { get; set; }

        /// <summary>
        /// The person's address.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The Kana variation of the person's address (Japan only).
        /// </summary>
        [JsonProperty("address_kana")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_kana")]
#endif
        public AddressJapanOptions AddressKana { get; set; }

        /// <summary>
        /// The Kanji variation of the person's address (Japan only).
        /// </summary>
        [JsonProperty("address_kanji")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_kanji")]
#endif
        public AddressJapanOptions AddressKanji { get; set; }

        /// <summary>
        /// The person's date of birth.
        /// </summary>
        [JsonProperty("dob")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dob")]
#endif
        public AccountPersonDobOptions Dob { get; set; }

        /// <summary>
        /// Documents that may be submitted to satisfy various informational requests.
        /// </summary>
        [JsonProperty("documents")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("documents")]
#endif
        public AccountPersonDocumentsOptions Documents { get; set; }

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
        /// The person's gender (International regulations require either "male" or "female").
        /// </summary>
        [JsonProperty("gender")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gender")]
#endif
        public string Gender { get; set; }

        /// <summary>
        /// The person's ID number, as appropriate for their country. For example, a social security
        /// number in the U.S., social insurance number in Canada, etc. Instead of the number
        /// itself, you can also provide a <a
        /// href="https://docs.stripe.com/js/tokens/create_token?type=pii">PII token provided by
        /// Stripe.js</a>.
        /// </summary>
        [JsonProperty("id_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id_number")]
#endif
        public string IdNumber { get; set; }

        /// <summary>
        /// The person's secondary ID number, as appropriate for their country, will be used for
        /// enhanced verification checks. In Thailand, this would be the laser code found on the
        /// back of an ID card. Instead of the number itself, you can also provide a <a
        /// href="https://docs.stripe.com/js/tokens/create_token?type=pii">PII token provided by
        /// Stripe.js</a>.
        /// </summary>
        [JsonProperty("id_number_secondary")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id_number_secondary")]
#endif
        public string IdNumberSecondary { get; set; }

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
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The country where the person is a national. Two-letter country code (<a
        /// href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</a>), or "XX"
        /// if unavailable.
        /// </summary>
        [JsonProperty("nationality")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("nationality")]
#endif
        public string Nationality { get; set; }

        /// <summary>
        /// A <a href="https://docs.stripe.com/connect/account-tokens">person token</a>, used to
        /// securely provide details to the person.
        /// </summary>
        [JsonProperty("person_token")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("person_token")]
#endif
        public string PersonToken { get; set; }

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

        /// <summary>
        /// The person's registered address.
        /// </summary>
        [JsonProperty("registered_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("registered_address")]
#endif
        public AddressOptions RegisteredAddress { get; set; }

        /// <summary>
        /// The relationship that this person has with the account's legal entity.
        /// </summary>
        [JsonProperty("relationship")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("relationship")]
#endif
        public AccountPersonRelationshipOptions Relationship { get; set; }

        /// <summary>
        /// The last four digits of the person's Social Security number (U.S. only).
        /// </summary>
        [JsonProperty("ssn_last_4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ssn_last_4")]
#endif
        public string SsnLast4 { get; set; }

        /// <summary>
        /// Demographic data related to the person.
        /// </summary>
        [JsonProperty("us_cfpb_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_cfpb_data")]
#endif
        public AccountPersonUsCfpbDataOptions UsCfpbData { get; set; }

        /// <summary>
        /// The person's verification status.
        /// </summary>
        [JsonProperty("verification")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verification")]
#endif
        public AccountPersonVerificationOptions Verification { get; set; }
    }
}
