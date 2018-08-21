namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class LegalEntity : StripeEntity
    {
        [JsonProperty("additional_owners")]
        public List<AdditionalOwners> AdditionalOwners { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("address_kana")]
        public Address AddressKana { get; set; }

        [JsonProperty("address_kanji")]
        public Address AddressKanji { get; set; }

        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        [JsonProperty("business_name_kana")]
        public string BusinessNameKana { get; set; }

        [JsonProperty("business_name_kanji")]
        public string BusinessNameKanji { get; set; }

        /// <summary>
        /// Whether the business ID number of the legal entity has been provided.
        /// </summary>
        [JsonProperty("business_tax_id_provided")]
        public bool BusinessTaxIdProvided { get; set; }

        /// <summary>
        /// Whether the business VAT number of the legal entity has been provided.
        /// </summary>
        [JsonProperty("business_vat_id_provided")]
        public bool BusinessVatIdProvided { get; set; }

        [JsonProperty("dob")]
        public BirthDay BirthDay { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("first_name_kana")]
        public string FirstNameKana { get; set; }

        [JsonProperty("first_name_kanji")]
        public string FirstNameKanji { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("last_name_kana")]
        public string LastNameKana { get; set; }

        [JsonProperty("last_name_kanji")]
        public string LastNameKanji { get; set; }

        [JsonProperty("maiden_name")]
        public string MaidenName { get; set; }

        [JsonProperty("personal_address")]
        public Address PersonalAddress { get; set; }

        [JsonProperty("personal_address_kana")]
        public Address PersonalAddressKana { get; set; }

        [JsonProperty("personal_address_kanji")]
        public Address PersonalAddressKanji { get; set; }

        [JsonProperty("personal_id_number_provided")]
        public bool PersonalIdNumberProvided { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("ssn_last_4_provided")]
        public bool SocialSecurityNumberLastFourProvided { get; set; }

        [JsonProperty("tax_id_registrar")]
        public string TaxIdRegistrar { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("verification")]
        public LegalEntityVerification LegalEntityVerification { get; set; }
    }
}
