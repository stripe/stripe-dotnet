// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCompanyOptions : INestedOptions
    {
        /// <summary>
        /// The company's primary address.
        /// </summary>
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The Kana variation of the company's primary address (Japan only).
        /// </summary>
        [JsonProperty("address_kana")]
        public AddressJapanOptions AddressKana { get; set; }

        /// <summary>
        /// The Kanji variation of the company's primary address (Japan only).
        /// </summary>
        [JsonProperty("address_kanji")]
        public AddressJapanOptions AddressKanji { get; set; }

        /// <summary>
        /// Whether the company's directors have been provided. Set this Boolean to <c>true</c>
        /// after creating all the company's directors with <a
        /// href="https://stripe.com/docs/api/persons">the Persons API</a> for accounts with a
        /// <c>relationship.director</c> requirement. This value is not automatically set to
        /// <c>true</c> after creating directors, so it needs to be updated to indicate all
        /// directors have been provided.
        /// </summary>
        [JsonProperty("directors_provided")]
        public bool? DirectorsProvided { get; set; }

        /// <summary>
        /// Whether the company's executives have been provided. Set this Boolean to <c>true</c>
        /// after creating all the company's executives with <a
        /// href="https://stripe.com/docs/api/persons">the Persons API</a> for accounts with a
        /// <c>relationship.executive</c> requirement.
        /// </summary>
        [JsonProperty("executives_provided")]
        public bool? ExecutivesProvided { get; set; }

        /// <summary>
        /// The export license ID number of the company, also referred as Import Export Code (India
        /// only).
        /// </summary>
        [JsonProperty("export_license_id")]
        public string ExportLicenseId { get; set; }

        /// <summary>
        /// The purpose code to use for export transactions (India only).
        /// </summary>
        [JsonProperty("export_purpose_code")]
        public string ExportPurposeCode { get; set; }

        /// <summary>
        /// The company's legal name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The Kana variation of the company's legal name (Japan only).
        /// </summary>
        [JsonProperty("name_kana")]
        public string NameKana { get; set; }

        /// <summary>
        /// The Kanji variation of the company's legal name (Japan only).
        /// </summary>
        [JsonProperty("name_kanji")]
        public string NameKanji { get; set; }

        /// <summary>
        /// Whether the company's owners have been provided. Set this Boolean to <c>true</c> after
        /// creating all the company's owners with <a href="https://stripe.com/docs/api/persons">the
        /// Persons API</a> for accounts with a <c>relationship.owner</c> requirement.
        /// </summary>
        [JsonProperty("owners_provided")]
        public bool? OwnersProvided { get; set; }

        /// <summary>
        /// This hash is used to attest that the beneficial owner information provided to Stripe is
        /// both current and correct.
        /// </summary>
        [JsonProperty("ownership_declaration")]
        public AccountCompanyOwnershipDeclarationOptions OwnershipDeclaration { get; set; }

        /// <summary>
        /// The company's phone number (used for verification).
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The identification number given to a company when it is registered or incorporated, if
        /// distinct from the identification number used for filing taxes. (Examples are the CIN for
        /// companies and LLP IN for partnerships in India, and the Company Registration Number in
        /// Hong Kong).
        /// </summary>
        [JsonProperty("registration_number")]
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// The category identifying the legal structure of the company or legal entity. See <a
        /// href="https://stripe.com/docs/connect/identity-verification#business-structure">Business
        /// structure</a> for more details.
        /// One of: <c>free_zone_establishment</c>, <c>free_zone_llc</c>,
        /// <c>government_instrumentality</c>, <c>governmental_unit</c>,
        /// <c>incorporated_non_profit</c>, <c>incorporated_partnership</c>,
        /// <c>limited_liability_partnership</c>, <c>llc</c>, <c>multi_member_llc</c>,
        /// <c>private_company</c>, <c>private_corporation</c>, <c>private_partnership</c>,
        /// <c>public_company</c>, <c>public_corporation</c>, <c>public_partnership</c>,
        /// <c>single_member_llc</c>, <c>sole_establishment</c>, <c>sole_proprietorship</c>,
        /// <c>tax_exempt_government_instrumentality</c>, <c>unincorporated_association</c>,
        /// <c>unincorporated_non_profit</c>, or <c>unincorporated_partnership</c>.
        /// </summary>
        [JsonProperty("structure")]
        public string Structure { get; set; }

        /// <summary>
        /// The business ID number of the company, as appropriate for the company’s country.
        /// (Examples are an Employer ID Number in the U.S., a Business Number in Canada, or a
        /// Company Number in the UK.).
        /// </summary>
        [JsonProperty("tax_id")]
        public string TaxId { get; set; }

        /// <summary>
        /// The jurisdiction in which the <c>tax_id</c> is registered (Germany-based companies
        /// only).
        /// </summary>
        [JsonProperty("tax_id_registrar")]
        public string TaxIdRegistrar { get; set; }

        /// <summary>
        /// The VAT number of the company.
        /// </summary>
        [JsonProperty("vat_id")]
        public string VatId { get; set; }

        /// <summary>
        /// Information on the verification state of the company.
        /// </summary>
        [JsonProperty("verification")]
        public AccountCompanyVerificationOptions Verification { get; set; }
    }
}
