namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCompanyOptions : INestedOptions
    {
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        [JsonProperty("address_kana")]
        public AddressJapanOptions AddressKana { get; set; }

        [JsonProperty("address_kanji")]
        public AddressJapanOptions AddressKanji { get; set; }

        [JsonProperty("directors_provided")]
        public bool? DirectorsProvided { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_kana")]
        public string NameKana { get; set; }

        [JsonProperty("name_kanji")]
        public string NameKanji { get; set; }

        [JsonProperty("owners_provided")]
        public bool? OwnersProvided { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("tax_id")]
        public string TaxId { get; set; }

        [JsonProperty("vat_id")]
        public string VatId { get; set; }
    }
}
