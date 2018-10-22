namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class AccountLegalEntityOptions : INestedOptions
    {
        [JsonProperty("additional_owners")]
        public List<AccountAdditionalOwner> AdditionalOwners { get; set; }

        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        [JsonProperty("address_kana")]
        public AddressJapanOptions AddressKana { get; set; }

        [JsonProperty("address_kanji")]
        public AddressJapanOptions AddressKanji { get; set; }

        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        [JsonProperty("business_name_kana")]
        public string BusinessNameKana { get; set; }

        [JsonProperty("business_name_kanji")]
        public string BusinessNameKanji { get; set; }

        [JsonProperty("business_tax_id")]
        public string BusinessTaxId { get; set; }

        [JsonProperty("business_vat_id")]
        public string BusinessVatId { get; set; }

        [JsonProperty("dob")]
        public AccountDobOptions Dob { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("first_name_kana")]
        public string FirstNameKana { get; set; }

        [JsonProperty("first_name_kanji")]
        public string FirstNameKanji { get; set; }

        /// <summary>
        /// The gender of the individual responsible for the account (International regulations require either “male” or “female”)
        /// </summary>
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
        public AddressOptions PersonalAddress { get; set; }

        [JsonProperty("personal_address_kana")]
        public AddressJapanOptions PersonalAddressKana { get; set; }

        [JsonProperty("personal_address_kanji")]
        public AddressJapanOptions PersonalAddressKanji { get; set; }

        [JsonProperty("personal_id_number")]
        public string PersonalIdNumber { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("ssn_last_4")]
        public string SSNLast4 { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("verification")]
        public AccountVerificationOptions Verification { get; set; }
    }
}
