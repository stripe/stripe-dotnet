// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TokenAccountCompanyOptions : INestedOptions
    {
        /// <summary>
        /// The company's primary address.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The Kana variation of the company's primary address (Japan only).
        /// </summary>
        [JsonProperty("address_kana")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_kana")]
#endif
        public AddressJapanOptions AddressKana { get; set; }

        /// <summary>
        /// The Kanji variation of the company's primary address (Japan only).
        /// </summary>
        [JsonProperty("address_kanji")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_kanji")]
#endif
        public AddressJapanOptions AddressKanji { get; set; }

        /// <summary>
        /// Whether the company's directors have been provided. Set this Boolean to <c>true</c>
        /// after creating all the company's directors with <a
        /// href="https://stripe.com/api/persons">the Persons API</a> for accounts with a
        /// <c>relationship.director</c> requirement. This value is not automatically set to
        /// <c>true</c> after creating directors, so it needs to be updated to indicate all
        /// directors have been provided.
        /// </summary>
        [JsonProperty("directors_provided")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("directors_provided")]
#endif
        public bool? DirectorsProvided { get; set; }

        /// <summary>
        /// This hash is used to attest that the directors information provided to Stripe is both
        /// current and correct.
        /// </summary>
        [JsonProperty("directorship_declaration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("directorship_declaration")]
#endif
        public TokenAccountCompanyDirectorshipDeclarationOptions DirectorshipDeclaration { get; set; }

        /// <summary>
        /// Whether the company's executives have been provided. Set this Boolean to <c>true</c>
        /// after creating all the company's executives with <a
        /// href="https://stripe.com/api/persons">the Persons API</a> for accounts with a
        /// <c>relationship.executive</c> requirement.
        /// </summary>
        [JsonProperty("executives_provided")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("executives_provided")]
#endif
        public bool? ExecutivesProvided { get; set; }

        /// <summary>
        /// The export license ID number of the company, also referred as Import Export Code (India
        /// only).
        /// </summary>
        [JsonProperty("export_license_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("export_license_id")]
#endif
        public string ExportLicenseId { get; set; }

        /// <summary>
        /// The purpose code to use for export transactions (India only).
        /// </summary>
        [JsonProperty("export_purpose_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("export_purpose_code")]
#endif
        public string ExportPurposeCode { get; set; }

        /// <summary>
        /// The company's legal name.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// The Kana variation of the company's legal name (Japan only).
        /// </summary>
        [JsonProperty("name_kana")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name_kana")]
#endif
        public string NameKana { get; set; }

        /// <summary>
        /// The Kanji variation of the company's legal name (Japan only).
        /// </summary>
        [JsonProperty("name_kanji")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name_kanji")]
#endif
        public string NameKanji { get; set; }

        /// <summary>
        /// Whether the company's owners have been provided. Set this Boolean to <c>true</c> after
        /// creating all the company's owners with <a href="https://stripe.com/api/persons">the
        /// Persons API</a> for accounts with a <c>relationship.owner</c> requirement.
        /// </summary>
        [JsonProperty("owners_provided")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("owners_provided")]
#endif
        public bool? OwnersProvided { get; set; }

        /// <summary>
        /// This hash is used to attest that the beneficial owner information provided to Stripe is
        /// both current and correct.
        /// </summary>
        [JsonProperty("ownership_declaration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ownership_declaration")]
#endif
        public TokenAccountCompanyOwnershipDeclarationOptions OwnershipDeclaration { get; set; }

        /// <summary>
        /// Whether the user described by the data in the token has been shown the Ownership
        /// Declaration and indicated that it is correct.
        /// </summary>
        [JsonProperty("ownership_declaration_shown_and_signed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ownership_declaration_shown_and_signed")]
#endif
        public bool? OwnershipDeclarationShownAndSigned { get; set; }

        /// <summary>
        /// One of: <c>qualified_entity_exceeds_ownership_threshold</c>, or
        /// <c>qualifies_as_financial_institution</c>.
        /// </summary>
        [JsonProperty("ownership_exemption_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ownership_exemption_reason")]
#endif
        public string OwnershipExemptionReason { get; set; }

        /// <summary>
        /// The company's phone number (used for verification).
        /// </summary>
        [JsonProperty("phone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone")]
#endif
        public string Phone { get; set; }

        /// <summary>
        /// The identification number given to a company when it is registered or incorporated, if
        /// distinct from the identification number used for filing taxes. (Examples are the CIN for
        /// companies and LLP IN for partnerships in India, and the Company Registration Number in
        /// Hong Kong).
        /// </summary>
        [JsonProperty("registration_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("registration_number")]
#endif
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// The category identifying the legal structure of the company or legal entity. See <a
        /// href="https://stripe.com/connect/identity-verification#business-structure">Business
        /// structure</a> for more details. Pass an empty string to unset this value.
        /// One of: <c>free_zone_establishment</c>, <c>free_zone_llc</c>,
        /// <c>government_instrumentality</c>, <c>governmental_unit</c>,
        /// <c>incorporated_non_profit</c>, <c>incorporated_partnership</c>,
        /// <c>limited_liability_partnership</c>, <c>llc</c>, <c>multi_member_llc</c>,
        /// <c>private_company</c>, <c>private_corporation</c>, <c>private_partnership</c>,
        /// <c>public_company</c>, <c>public_corporation</c>, <c>public_partnership</c>,
        /// <c>registered_charity</c>, <c>single_member_llc</c>, <c>sole_establishment</c>,
        /// <c>sole_proprietorship</c>, <c>tax_exempt_government_instrumentality</c>,
        /// <c>unincorporated_association</c>, <c>unincorporated_non_profit</c>, or
        /// <c>unincorporated_partnership</c>.
        /// </summary>
        [JsonProperty("structure")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("structure")]
#endif
        public string Structure { get; set; }

        /// <summary>
        /// The business ID number of the company, as appropriate for the company’s country.
        /// (Examples are an Employer ID Number in the U.S., a Business Number in Canada, or a
        /// Company Number in the UK.).
        /// </summary>
        [JsonProperty("tax_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_id")]
#endif
        public string TaxId { get; set; }

        /// <summary>
        /// The jurisdiction in which the <c>tax_id</c> is registered (Germany-based companies
        /// only).
        /// </summary>
        [JsonProperty("tax_id_registrar")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_id_registrar")]
#endif
        public string TaxIdRegistrar { get; set; }

        /// <summary>
        /// The VAT number of the company.
        /// </summary>
        [JsonProperty("vat_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("vat_id")]
#endif
        public string VatId { get; set; }

        /// <summary>
        /// Information on the verification state of the company.
        /// </summary>
        [JsonProperty("verification")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verification")]
#endif
        public TokenAccountCompanyVerificationOptions Verification { get; set; }
    }
}
