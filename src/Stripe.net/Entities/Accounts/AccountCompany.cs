// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCompany : StripeEntity<AccountCompany>
    {
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public Address Address { get; set; }

        /// <summary>
        /// The Kana variation of the company's primary address (Japan only).
        /// </summary>
        [JsonProperty("address_kana")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_kana")]
#endif
        public AddressJapan AddressKana { get; set; }

        /// <summary>
        /// The Kanji variation of the company's primary address (Japan only).
        /// </summary>
        [JsonProperty("address_kanji")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_kanji")]
#endif
        public AddressJapan AddressKanji { get; set; }

        /// <summary>
        /// Whether the company's directors have been provided. This Boolean will be <c>true</c> if
        /// you've manually indicated that all directors are provided via <a
        /// href="https://stripe.com/docs/api/accounts/update#update_account-company-directors_provided">the
        /// <c>directors_provided</c> parameter</a>.
        /// </summary>
        [JsonProperty("directors_provided")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("directors_provided")]
#endif
        public bool DirectorsProvided { get; set; }

        /// <summary>
        /// This hash is used to attest that the director information provided to Stripe is both
        /// current and correct.
        /// </summary>
        [JsonProperty("directorship_declaration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("directorship_declaration")]
#endif
        public AccountCompanyDirectorshipDeclaration DirectorshipDeclaration { get; set; }

        /// <summary>
        /// Whether the company's executives have been provided. This Boolean will be <c>true</c> if
        /// you've manually indicated that all executives are provided via <a
        /// href="https://stripe.com/docs/api/accounts/update#update_account-company-executives_provided">the
        /// <c>executives_provided</c> parameter</a>, or if Stripe determined that sufficient
        /// executives were provided.
        /// </summary>
        [JsonProperty("executives_provided")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("executives_provided")]
#endif
        public bool ExecutivesProvided { get; set; }

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
        /// Whether the company's owners have been provided. This Boolean will be <c>true</c> if
        /// you've manually indicated that all owners are provided via <a
        /// href="https://stripe.com/docs/api/accounts/update#update_account-company-owners_provided">the
        /// <c>owners_provided</c> parameter</a>, or if Stripe determined that sufficient owners
        /// were provided. Stripe determines ownership requirements using both the number of owners
        /// provided and their total percent ownership (calculated by adding the
        /// <c>percent_ownership</c> of each owner together).
        /// </summary>
        [JsonProperty("owners_provided")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("owners_provided")]
#endif
        public bool OwnersProvided { get; set; }

        /// <summary>
        /// This hash is used to attest that the beneficial owner information provided to Stripe is
        /// both current and correct.
        /// </summary>
        [JsonProperty("ownership_declaration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ownership_declaration")]
#endif
        public AccountCompanyOwnershipDeclaration OwnershipDeclaration { get; set; }

        /// <summary>
        /// This value is used to determine if a business is exempt from providing ultimate
        /// beneficial owners. See <a
        /// href="https://support.stripe.com/questions/exemption-from-providing-ownership-details">this
        /// support article</a> and <a
        /// href="https://docs.stripe.com/changelog/acacia/2025-01-27/ownership-exemption-reason-accounts-api">changelog</a>
        /// for more details.
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
        /// The category identifying the legal structure of the company or legal entity. See <a
        /// href="https://stripe.com/docs/connect/identity-verification#business-structure">Business
        /// structure</a> for more details.
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
        /// Whether the company's business ID number was provided.
        /// </summary>
        [JsonProperty("tax_id_provided")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_id_provided")]
#endif
        public bool TaxIdProvided { get; set; }

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
        /// Whether the company's business VAT number was provided.
        /// </summary>
        [JsonProperty("vat_id_provided")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("vat_id_provided")]
#endif
        public bool VatIdProvided { get; set; }

        /// <summary>
        /// Information on the verification state of the company.
        /// </summary>
        [JsonProperty("verification")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verification")]
#endif
        public AccountCompanyVerification Verification { get; set; }
    }
}
