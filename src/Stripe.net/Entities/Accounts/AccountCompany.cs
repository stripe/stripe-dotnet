namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCompany : StripeEntity<AccountCompany>
    {
        [JsonProperty("address")]
        public Address Address { get; set; }

        /// <summary>
        /// The Kana variation of the company's primary address (Japan only).
        /// </summary>
        [JsonProperty("address_kana")]
        public AddressJapan AddressKana { get; set; }

        /// <summary>
        /// The Kanji variation of the company's primary address (Japan only).
        /// </summary>
        [JsonProperty("address_kanji")]
        public AddressJapan AddressKanji { get; set; }

        /// <summary>
        /// Whether the company's directors have been provided. This Boolean will be <c>true</c> if
        /// you've manually indicated that all directors are provided via <a
        /// href="https://stripe.com/docs/api/accounts/update#update_account-company-directors_provided">the
        /// <c>directors_provided</c> parameter</a>.
        /// </summary>
        [JsonProperty("directors_provided")]
        public bool DirectorsProvided { get; set; }

        /// <summary>
        /// Whether the company's executives have been provided. This Boolean will be <c>true</c> if
        /// you've manually indicated that all executives are provided via <a
        /// href="https://stripe.com/docs/api/accounts/update#update_account-company-executives_provided">the
        /// <c>executives_provided</c> parameter</a>, or if Stripe determined that sufficient
        /// executives were provided.
        /// </summary>
        [JsonProperty("executives_provided")]
        public bool ExecutivesProvided { get; set; }

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
        /// Whether the company's owners have been provided. This Boolean will be <c>true</c> if
        /// you've manually indicated that all owners are provided via <a
        /// href="https://stripe.com/docs/api/accounts/update#update_account-company-owners_provided">the
        /// <c>owners_provided</c> parameter</a>, or if Stripe determined that sufficient owners
        /// were provided. Stripe determines ownership requirements using both the number of owners
        /// provided and their total percent ownership (calculated by adding the
        /// <c>percent_ownership</c> of each owner together).
        /// </summary>
        [JsonProperty("owners_provided")]
        public bool OwnersProvided { get; set; }

        /// <summary>
        /// The company's phone number (used for verification).
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The category identifying the legal structure of the company or legal entity. See <a
        /// href="https://stripe.com/docs/connect/identity-verification#business-structure">Business
        /// structure</a> for more details.
        /// One of: <c>government_instrumentality</c>, <c>governmental_unit</c>,
        /// <c>incorporated_non_profit</c>, <c>limited_liability_partnership</c>,
        /// <c>multi_member_llc</c>, <c>private_company</c>, <c>private_corporation</c>,
        /// <c>private_partnership</c>, <c>public_company</c>, <c>public_corporation</c>,
        /// <c>public_partnership</c>, <c>sole_proprietorship</c>,
        /// <c>tax_exempt_government_instrumentality</c>, <c>unincorporated_association</c>, or
        /// <c>unincorporated_non_profit</c>.
        /// </summary>
        [JsonProperty("structure")]
        public string Structure { get; set; }

        /// <summary>
        /// Whether the company's business ID number was provided.
        /// </summary>
        [JsonProperty("tax_id_provided")]
        public bool TaxIdProvided { get; set; }

        /// <summary>
        /// The jurisdiction in which the <c>tax_id</c> is registered (Germany-based companies
        /// only).
        /// </summary>
        [JsonProperty("tax_id_registrar")]
        public string TaxIdRegistrar { get; set; }

        /// <summary>
        /// Whether the company's business VAT number was provided.
        /// </summary>
        [JsonProperty("vat_id_provided")]
        public bool VatIdProvided { get; set; }

        /// <summary>
        /// Information on the verification state of the company.
        /// </summary>
        [JsonProperty("verification")]
        public AccountCompanyVerification Verification { get; set; }
    }
}
