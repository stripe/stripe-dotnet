using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeAccountLegalEntityOptions : INestedOptions
    {
        #region Address

        [JsonProperty("legal_entity[address][city]")]
        public string AddressCity { get; set; }

        [JsonProperty("legal_entity[address][country]")]
        public string AddressTwoLetterCountry { get; set; }

        [JsonProperty("legal_entity[address][line1]")]
        public string AddressLine1 { get; set; }

        [JsonProperty("legal_entity[address][line2]")]
        public string AddressLine2 { get; set; }

        [JsonProperty("legal_entity[address][postal_code]")]
        public string AddressPostalCode { get; set; }

        [JsonProperty("legal_entity[address][state]")]
        public string AddressState { get; set; }

        #endregion

        #region Address Kana

        [JsonProperty("legal_entity[address_kana][city]")]
        public string AddressKanaCity { get; set; }

        [JsonProperty("legal_entity[address_kana][country]")]
        public string AddressKanaTwoLetterCountry { get; set; }

        [JsonProperty("legal_entity[address_kana][line1]")]
        public string AddressKanaLine1 { get; set; }

        [JsonProperty("legal_entity[address_kana][line2]")]
        public string AddressKanaLine2 { get; set; }

        [JsonProperty("legal_entity[address_kana][postal_code]")]
        public string AddressKanaPostalCode { get; set; }

        [JsonProperty("legal_entity[address_kana][state]")]
        public string AddressKanaState { get; set; }

        [JsonProperty("legal_entity[address_kana][town]")]
        public string AddressKanaTown { get; set; }

        #endregion

        #region Address Kanji

        [JsonProperty("legal_entity[address_kanji][city]")]
        public string AddressKanjiCity { get; set; }

        [JsonProperty("legal_entity[address_kanji][country]")]
        public string AddressKanjiTwoLetterCountry { get; set; }

        [JsonProperty("legal_entity[address_kanji][line1]")]
        public string AddressKanjiLine1 { get; set; }

        [JsonProperty("legal_entity[address_kanji][line2]")]
        public string AddressKanjiLine2 { get; set; }

        [JsonProperty("legal_entity[address_kanji][postal_code]")]
        public string AddressKanjiPostalCode { get; set; }

        [JsonProperty("legal_entity[address_kanji][state]")]
        public string AddressKanjiState { get; set; }

        [JsonProperty("legal_entity[address_kanji][town]")]
        public string AddressKanjiTown { get; set; }

        #endregion

        [JsonProperty("legal_entity[business_name]")]
        public string BusinessName { get; set; }

        [JsonProperty("legal_entity[business_name_kana]")]
        public string BusinessNameKana { get; set; }

        [JsonProperty("legal_entity[business_name_kanji]")]
        public string BusinessNameKanji { get; set; }

        [JsonProperty("legal_entity[business_tax_id]")]
        public string BusinessTaxId { get; set; }

        [JsonProperty("legal_entity[business_vat_id]")]
        public string BusinessVatId { get; set; }

        #region Date of Birth

        [JsonProperty("legal_entity[dob][day]")]
        public int? BirthDay { get; set; }

        [JsonProperty("legal_entity[dob][month]")]
        public int? BirthMonth { get; set; }

        [JsonProperty("legal_entity[dob][year]")]
        public int? BirthYear { get; set; }

        #endregion

        [JsonProperty("legal_entity[first_name]")]
        public string FirstName { get; set; }

        [JsonProperty("legal_entity[first_name_kana]")]
        public string FirstNameKana { get; set; }

        [JsonProperty("legal_entity[first_name_kanji]")]
        public string FirstNameKanji { get; set; }

        /// <summary>
        /// The gender of the individual responsible for the account (International regulations require either “male” or “female”)
        /// </summary>
        [JsonProperty("legal_entity[gender]")]
        public string Gender { get; set; }

        [JsonProperty("legal_entity[last_name]")]
        public string LastName { get; set; }

        [JsonProperty("legal_entity[last_name_kana]")]
        public string LastNameKana { get; set; }

        [JsonProperty("legal_entity[last_name_kanji]")]
        public string LastNameKanji { get; set; }

        [JsonProperty("legal_entity[maiden_name]")]
        public string MaidenName { get; set; }

        #region Personal Address

        [JsonProperty("legal_entity[personal_address][city]")]
        public string PersonalAddressCity { get; set; }

        [JsonProperty("legal_entity[personal_address][country]")]
        public string PersonalAddressTwoLetterCountry { get; set; }

        [JsonProperty("legal_entity[personal_address][line1]")]
        public string PersonalAddressLine1 { get; set; }

        [JsonProperty("legal_entity[personal_address][line2]")]
        public string PersonalAddressLine2 { get; set; }

        [JsonProperty("legal_entity[personal_address][postal_code]")]
        public string PersonalAddressPostalCode { get; set; }

        [JsonProperty("legal_entity[personal_address][state]")]
        public string PersonalAddressState { get; set; }

        #endregion

        #region Personal Address Kana

        [JsonProperty("legal_entity[personal_address_kana][city]")]
        public string PersonalAddressKanaCity { get; set; }

        [JsonProperty("legal_entity[personal_address_kana][country]")]
        public string PersonalAddressKanaTwoLetterCountry { get; set; }

        [JsonProperty("legal_entity[personal_address_kana][line1]")]
        public string PersonalAddressKanaLine1 { get; set; }

        [JsonProperty("legal_entity[personal_address_kana][line2]")]
        public string PersonalAddressKanaLine2 { get; set; }

        [JsonProperty("legal_entity[personal_address_kana][postal_code]")]
        public string PersonalAddressKanaPostalCode { get; set; }

        [JsonProperty("legal_entity[personal_address_kana][state]")]
        public string PersonalAddressKanaState { get; set; }

        [JsonProperty("legal_entity[personal_address_kana][town]")]
        public string PersonalAddressKanaTown { get; set; }

        #endregion

        #region Personal Address Kanji

        [JsonProperty("legal_entity[personal_address_kanji][city]")]
        public string PersonalAddressKanjiCity { get; set; }

        [JsonProperty("legal_entity[personal_address_kanji][country]")]
        public string PersonalAddressKanjiTwoLetterCountry { get; set; }

        [JsonProperty("legal_entity[personal_address_kanji][line1]")]
        public string PersonalAddressKanjiLine1 { get; set; }

        [JsonProperty("legal_entity[personal_address_kanji][line2]")]
        public string PersonalAddressKanjiLine2 { get; set; }

        [JsonProperty("legal_entity[personal_address_kanji][postal_code]")]
        public string PersonalAddressKanjiPostalCode { get; set; }

        [JsonProperty("legal_entity[personal_address_kanji][state]")]
        public string PersonalAddressKanjiState { get; set; }

        [JsonProperty("legal_entity[personal_address_kanji][town]")]
        public string PersonalAddressKanjiTown { get; set; }

        #endregion

        [JsonProperty("legal_entity[personal_id_number]")]
        public string PersonalIdNumber { get; set; }

        [JsonProperty("legal_entity[phone_number]")]
        public string PhoneNumber { get; set; }

        [JsonProperty("legal_entity[ssn_last_4]")]
        public string SSNLast4 { get; set; }

        [JsonProperty("legal_entity[type]")]
        public string Type { get; set; }

        #region Verification

        [JsonProperty("legal_entity[verification][document]")]
        public string VerificationDocumentFileId { get; set; }

        #endregion

        #region Additional Owners

        [JsonProperty("legal_entity[additional_owners]")]
        public List<StripeAccountAdditionalOwner> AdditionalOwners { get; set; }

        #endregion
    }
}
