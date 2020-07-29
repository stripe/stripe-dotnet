namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCompany : StripeEntity<AccountCompany>
    {
        /// <summary>
        /// The company's primary address.
        /// </summary>
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
        /// Whether information was collected from the company's directors.
        /// </summary>
        [JsonProperty("directors_provided")]
        public bool DirectorsProvided { get; set; }

        /// <summary>
        ///  Whether the company's executives have been provided. Set this
        ///  Boolean to <c>true</c> after creating all the company's executives with
        ///  <a href="https://stripe.com/docs/api/persons">the Persons API</a> for
        ///  accounts with a <c>relationship.executive</c> requirement.
        /// </summary>
        [JsonProperty("executives_provided")]
        public bool ExecutivesProvided { get; set; }

        /// <summary>
        /// The company's legal name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The Kana variation of the company's legal name Japan only).
        /// </summary>
        [JsonProperty("name_kana")]
        public string NameKana { get; set; }

        /// <summary>
        /// The Kanji variation of the company's legal name (Japan only).
        /// </summary>
        [JsonProperty("name_kanji")]
        public string NameKanji { get; set; }

        /// <summary>
        /// Whether the company's owners have been provided.
        /// </summary>
        [JsonProperty("owners_provided")]
        public bool OwnersProvided { get; set; }

        /// <summary>
        /// The company's phone number (used for verification).
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The category identifying the legal structure of the company or legal entity.
        /// </summary>
        [JsonProperty("structure")]
        public string Structure { get; set; }

        /// <summary>
        /// Whether the company's business ID number was provided.
        /// </summary>
        [JsonProperty("tax_id_provided")]
        public bool TaxIdProvided { get; set; }

        /// <summary>
        /// The jurisdiction in which the <c>tax_id</c> is registered (Germany-based
        /// companies only).
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
