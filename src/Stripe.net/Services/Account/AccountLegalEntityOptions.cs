namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class AccountLegalEntityOptions : INestedOptions
    {
        #region Address

        [JsonProperty("address[city]")]
        public string AddressCity { get; set; }

        [JsonProperty("address[country]")]
        public string AddressTwoLetterCountry { get; set; }

        [JsonProperty("address[line1]")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address[line2]")]
        public string AddressLine2 { get; set; }

        [JsonProperty("address[postal_code]")]
        public string AddressPostalCode { get; set; }

        [JsonProperty("address[state]")]
        public string AddressState { get; set; }

        #endregion

        #region Address Kana

        [JsonProperty("address_kana[city]")]
        public string AddressKanaCity { get; set; }

        [JsonProperty("address_kana[country]")]
        public string AddressKanaTwoLetterCountry { get; set; }

        [JsonProperty("address_kana[line1]")]
        public string AddressKanaLine1 { get; set; }

        [JsonProperty("address_kana[line2]")]
        public string AddressKanaLine2 { get; set; }

        [JsonProperty("address_kana[postal_code]")]
        public string AddressKanaPostalCode { get; set; }

        [JsonProperty("address_kana[state]")]
        public string AddressKanaState { get; set; }

        [JsonProperty("address_kana[town]")]
        public string AddressKanaTown { get; set; }

        #endregion

        #region Address Kanji

        [JsonProperty("address_kanji[city]")]
        public string AddressKanjiCity { get; set; }

        [JsonProperty("address_kanji[country]")]
        public string AddressKanjiTwoLetterCountry { get; set; }

        [JsonProperty("address_kanji[line1]")]
        public string AddressKanjiLine1 { get; set; }

        [JsonProperty("address_kanji[line2]")]
        public string AddressKanjiLine2 { get; set; }

        [JsonProperty("address_kanji[postal_code]")]
        public string AddressKanjiPostalCode { get; set; }

        [JsonProperty("address_kanji[state]")]
        public string AddressKanjiState { get; set; }

        [JsonProperty("address_kanji[town]")]
        public string AddressKanjiTown { get; set; }

        #endregion

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

        #region Date of Birth

        [JsonProperty("dob[day]")]
        public int? BirthDay { get; set; }

        [JsonProperty("dob[month]")]
        public int? BirthMonth { get; set; }

        [JsonProperty("dob[year]")]
        public int? BirthYear { get; set; }

        #endregion

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

        #region Personal Address

        [JsonProperty("personal_address[city]")]
        public string PersonalAddressCity { get; set; }

        [JsonProperty("personal_address[country]")]
        public string PersonalAddressTwoLetterCountry { get; set; }

        [JsonProperty("personal_address[line1]")]
        public string PersonalAddressLine1 { get; set; }

        [JsonProperty("personal_address[line2]")]
        public string PersonalAddressLine2 { get; set; }

        [JsonProperty("personal_address[postal_code]")]
        public string PersonalAddressPostalCode { get; set; }

        [JsonProperty("personal_address[state]")]
        public string PersonalAddressState { get; set; }

        #endregion

        #region Personal Address Kana

        [JsonProperty("personal_address_kana[city]")]
        public string PersonalAddressKanaCity { get; set; }

        [JsonProperty("personal_address_kana[country]")]
        public string PersonalAddressKanaTwoLetterCountry { get; set; }

        [JsonProperty("personal_address_kana[line1]")]
        public string PersonalAddressKanaLine1 { get; set; }

        [JsonProperty("personal_address_kana[line2]")]
        public string PersonalAddressKanaLine2 { get; set; }

        [JsonProperty("personal_address_kana[postal_code]")]
        public string PersonalAddressKanaPostalCode { get; set; }

        [JsonProperty("personal_address_kana[state]")]
        public string PersonalAddressKanaState { get; set; }

        [JsonProperty("personal_address_kana[town]")]
        public string PersonalAddressKanaTown { get; set; }

        #endregion

        #region Personal Address Kanji

        [JsonProperty("personal_address_kanji[city]")]
        public string PersonalAddressKanjiCity { get; set; }

        [JsonProperty("personal_address_kanji[country]")]
        public string PersonalAddressKanjiTwoLetterCountry { get; set; }

        [JsonProperty("personal_address_kanji[line1]")]
        public string PersonalAddressKanjiLine1 { get; set; }

        [JsonProperty("personal_address_kanji[line2]")]
        public string PersonalAddressKanjiLine2 { get; set; }

        [JsonProperty("personal_address_kanji[postal_code]")]
        public string PersonalAddressKanjiPostalCode { get; set; }

        [JsonProperty("personal_address_kanji[state]")]
        public string PersonalAddressKanjiState { get; set; }

        [JsonProperty("personal_address_kanji[town]")]
        public string PersonalAddressKanjiTown { get; set; }

        #endregion

        [JsonProperty("personal_id_number")]
        public string PersonalIdNumber { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("ssn_last_4")]
        public string SSNLast4 { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        #region Verification

        [JsonProperty("verification[document]")]
        public string VerificationDocumentFileId { get; set; }

        [JsonProperty("verification[document_back]")]
        public string VerificationDocumentFileBackId { get; set; }

        #endregion

        #region Additional Owners

        [JsonProperty("additional_owners")]
        public List<AccountAdditionalOwner> AdditionalOwners { get; set; }

        #endregion
    }
}
