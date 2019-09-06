namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCompanyOptions : INestedOptions
    {
        /// <summary>
        /// The company’s primary address.
        /// </summary>
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The Kana variation of the company’s primary address (Japan only).
        /// </summary>
        [JsonProperty("address_kana")]
        public AddressJapanOptions AddressKana { get; set; }

        /// <summary>
        /// The Kanji variation of the company’s primary address (Japan only).
        /// </summary>
        [JsonProperty("address_kanji")]
        public AddressJapanOptions AddressKanji { get; set; }

        /// <summary>
        /// Whether the company’s directors have been provided. Set this to <c>true</c> after
        /// creating all the company’s directors for this account.
        /// </summary>
        [JsonProperty("directors_provided")]
        public bool? DirectorsProvided { get; set; }

        /// <summary>
        /// The company’s legal name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The Kana variation of the company’s legal name (Japan only).
        /// </summary>
        [JsonProperty("name_kana")]
        public string NameKana { get; set; }

        /// <summary>
        /// The Kanji variation of the company’s legal name (Japan only).
        /// </summary>
        [JsonProperty("name_kanji")]
        public string NameKanji { get; set; }

        /// <summary>
        /// Whether the company’s owners have been provided. Set this to <c>true</c> after creating
        /// all the company’s owners for this account.
        /// </summary>
        [JsonProperty("owners_provided")]
        public bool? OwnersProvided { get; set; }

        /// <summary>
        /// The company’s phone number (used for verification).
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The business ID number of the company, as appropriate for the company’s country.
        /// (Examples are an Employer ID Number in the U.S., a Business Number in Canada, or a
        /// Company Number in the UK.).
        /// </summary>
        [JsonProperty("tax_id")]
        public string TaxId { get; set; }

        /// <summary>
        /// The jurisdiction in which the tax id is registered (Germany-based companies only).
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
