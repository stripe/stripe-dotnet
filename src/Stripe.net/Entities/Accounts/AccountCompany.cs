namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCompany : StripeEntity<AccountCompany>
    {
        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("address_kana")]
        public AddressJapan AddressKana { get; set; }

        [JsonProperty("address_kanji")]
        public AddressJapan AddressKanji { get; set; }

        [JsonProperty("directors_provided")]
        public bool DirectorsProvided { get; set; }

        [JsonProperty("executives_provided")]
        public bool ExecutivesProvided { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_kana")]
        public string NameKana { get; set; }

        [JsonProperty("name_kanji")]
        public string NameKanji { get; set; }

        [JsonProperty("owners_provided")]
        public bool OwnersProvided { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("structure")]
        public string Structure { get; set; }

        [JsonProperty("tax_id_provided")]
        public bool TaxIdProvided { get; set; }

        [JsonProperty("tax_id_registrar")]
        public string TaxIdRegistrar { get; set; }

        [JsonProperty("vat_id_provided")]
        public bool VatIdProvided { get; set; }

        [JsonProperty("verification")]
        public AccountCompanyVerification Verification { get; set; }
    }
}
