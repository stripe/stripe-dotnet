namespace Stripe
{
#if USE_SYSTEM_TEXT_JSON
    using System.Text.Json.Serialization;
#else
    using Newtonsoft.Json;
#endif

    public class AccountCompany : StripeEntity<AccountCompany>
    {
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("address")]
#else
        [JsonProperty("address")]
#endif
        public Address Address { get; set; }

        /// <summary>
        /// The Kana variation of the company's primary address (Japan only).
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("address_kana")]
#else
        [JsonProperty("address_kana")]
#endif
        public AddressJapan AddressKana { get; set; }

        /// <summary>
        /// The Kanji variation of the company's primary address (Japan only).
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("address_kanji")]
#else
        [JsonProperty("address_kanji")]
#endif
        public AddressJapan AddressKanji { get; set; }

        /// <summary>
        /// Whether the company's directors have been provided. This Boolean will be <c>true</c> if
        /// you've manually indicated that all directors are provided via <a
        /// href="https://stripe.com/docs/api/accounts/update#update_account-company-directors_provided">the
        /// <c>directors_provided</c> parameter</a>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("directors_provided")]
#else
        [JsonProperty("directors_provided")]
#endif
        public bool DirectorsProvided { get; set; }

        /// <summary>
        /// Whether the company's executives have been provided. This Boolean will be <c>true</c> if
        /// you've manually indicated that all executives are provided via <a
        /// href="https://stripe.com/docs/api/accounts/update#update_account-company-executives_provided">the
        /// <c>executives_provided</c> parameter</a>, or if Stripe determined that sufficient
        /// executives were provided.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("executives_provided")]
#else
        [JsonProperty("executives_provided")]
#endif
        public bool ExecutivesProvided { get; set; }

        /// <summary>
        /// The export license ID number of the company, also referred as Import Export Code (India
        /// only).
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("export_license_id")]
#else
        [JsonProperty("export_license_id")]
#endif
        public string ExportLicenseId { get; set; }

        /// <summary>
        /// The purpose code to use for export transactions (India only).
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("export_purpose_code")]
#else
        [JsonProperty("export_purpose_code")]
#endif
        public string ExportPurposeCode { get; set; }

        /// <summary>
        /// The company's legal name.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("name")]
#else
        [JsonProperty("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// The Kana variation of the company's legal name (Japan only).
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("name_kana")]
#else
        [JsonProperty("name_kana")]
#endif
        public string NameKana { get; set; }

        /// <summary>
        /// The Kanji variation of the company's legal name (Japan only).
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("name_kanji")]
#else
        [JsonProperty("name_kanji")]
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
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("owners_provided")]
#else
        [JsonProperty("owners_provided")]
#endif
        public bool OwnersProvided { get; set; }

        /// <summary>
        /// This hash is used to attest that the beneficial owner information provided to Stripe is
        /// both current and correct.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("ownership_declaration")]
#else
        [JsonProperty("ownership_declaration")]
#endif
        public AccountCompanyOwnershipDeclaration OwnershipDeclaration { get; set; }

        /// <summary>
        /// The company's phone number (used for verification).
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("phone")]
#else
        [JsonProperty("phone")]
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
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("structure")]
#else
        [JsonProperty("structure")]
#endif
        public string Structure { get; set; }

        /// <summary>
        /// Whether the company's business ID number was provided.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("tax_id_provided")]
#else
        [JsonProperty("tax_id_provided")]
#endif
        public bool TaxIdProvided { get; set; }

        /// <summary>
        /// The jurisdiction in which the <c>tax_id</c> is registered (Germany-based companies
        /// only).
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("tax_id_registrar")]
#else
        [JsonProperty("tax_id_registrar")]
#endif
        public string TaxIdRegistrar { get; set; }

        /// <summary>
        /// Whether the company's business VAT number was provided.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("vat_id_provided")]
#else
        [JsonProperty("vat_id_provided")]
#endif
        public bool VatIdProvided { get; set; }

        /// <summary>
        /// Information on the verification state of the company.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("verification")]
#else
        [JsonProperty("verification")]
#endif
        public AccountCompanyVerification Verification { get; set; }
    }
}
