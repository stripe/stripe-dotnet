namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class AccountLegalEntityOptions : INestedOptions
    {
        #region Address

        [FormProperty("address[city]")]
        public string AddressCity { get; set; }

        [FormProperty("address[country]")]
        public string AddressTwoLetterCountry { get; set; }

        [FormProperty("address[line1]")]
        public string AddressLine1 { get; set; }

        [FormProperty("address[line2]")]
        public string AddressLine2 { get; set; }

        [FormProperty("address[postal_code]")]
        public string AddressPostalCode { get; set; }

        [FormProperty("address[state]")]
        public string AddressState { get; set; }

        #endregion

        #region Address Kana

        [FormProperty("address_kana[city]")]
        public string AddressKanaCity { get; set; }

        [FormProperty("address_kana[country]")]
        public string AddressKanaTwoLetterCountry { get; set; }

        [FormProperty("address_kana[line1]")]
        public string AddressKanaLine1 { get; set; }

        [FormProperty("address_kana[line2]")]
        public string AddressKanaLine2 { get; set; }

        [FormProperty("address_kana[postal_code]")]
        public string AddressKanaPostalCode { get; set; }

        [FormProperty("address_kana[state]")]
        public string AddressKanaState { get; set; }

        [FormProperty("address_kana[town]")]
        public string AddressKanaTown { get; set; }

        #endregion

        #region Address Kanji

        [FormProperty("address_kanji[city]")]
        public string AddressKanjiCity { get; set; }

        [FormProperty("address_kanji[country]")]
        public string AddressKanjiTwoLetterCountry { get; set; }

        [FormProperty("address_kanji[line1]")]
        public string AddressKanjiLine1 { get; set; }

        [FormProperty("address_kanji[line2]")]
        public string AddressKanjiLine2 { get; set; }

        [FormProperty("address_kanji[postal_code]")]
        public string AddressKanjiPostalCode { get; set; }

        [FormProperty("address_kanji[state]")]
        public string AddressKanjiState { get; set; }

        [FormProperty("address_kanji[town]")]
        public string AddressKanjiTown { get; set; }

        #endregion

        [FormProperty("business_name")]
        public string BusinessName { get; set; }

        [FormProperty("business_name_kana")]
        public string BusinessNameKana { get; set; }

        [FormProperty("business_name_kanji")]
        public string BusinessNameKanji { get; set; }

        [FormProperty("business_tax_id")]
        public string BusinessTaxId { get; set; }

        [FormProperty("business_vat_id")]
        public string BusinessVatId { get; set; }

        #region Date of Birth

        [FormProperty("dob[day]")]
        public int? BirthDay { get; set; }

        [FormProperty("dob[month]")]
        public int? BirthMonth { get; set; }

        [FormProperty("dob[year]")]
        public int? BirthYear { get; set; }

        #endregion

        [FormProperty("first_name")]
        public string FirstName { get; set; }

        [FormProperty("first_name_kana")]
        public string FirstNameKana { get; set; }

        [FormProperty("first_name_kanji")]
        public string FirstNameKanji { get; set; }

        /// <summary>
        /// The gender of the individual responsible for the account (International regulations require either “male” or “female”)
        /// </summary>
        [FormProperty("gender")]
        public string Gender { get; set; }

        [FormProperty("last_name")]
        public string LastName { get; set; }

        [FormProperty("last_name_kana")]
        public string LastNameKana { get; set; }

        [FormProperty("last_name_kanji")]
        public string LastNameKanji { get; set; }

        [FormProperty("maiden_name")]
        public string MaidenName { get; set; }

        #region Personal Address

        [FormProperty("personal_address[city]")]
        public string PersonalAddressCity { get; set; }

        [FormProperty("personal_address[country]")]
        public string PersonalAddressTwoLetterCountry { get; set; }

        [FormProperty("personal_address[line1]")]
        public string PersonalAddressLine1 { get; set; }

        [FormProperty("personal_address[line2]")]
        public string PersonalAddressLine2 { get; set; }

        [FormProperty("personal_address[postal_code]")]
        public string PersonalAddressPostalCode { get; set; }

        [FormProperty("personal_address[state]")]
        public string PersonalAddressState { get; set; }

        #endregion

        #region Personal Address Kana

        [FormProperty("personal_address_kana[city]")]
        public string PersonalAddressKanaCity { get; set; }

        [FormProperty("personal_address_kana[country]")]
        public string PersonalAddressKanaTwoLetterCountry { get; set; }

        [FormProperty("personal_address_kana[line1]")]
        public string PersonalAddressKanaLine1 { get; set; }

        [FormProperty("personal_address_kana[line2]")]
        public string PersonalAddressKanaLine2 { get; set; }

        [FormProperty("personal_address_kana[postal_code]")]
        public string PersonalAddressKanaPostalCode { get; set; }

        [FormProperty("personal_address_kana[state]")]
        public string PersonalAddressKanaState { get; set; }

        [FormProperty("personal_address_kana[town]")]
        public string PersonalAddressKanaTown { get; set; }

        #endregion

        #region Personal Address Kanji

        [FormProperty("personal_address_kanji[city]")]
        public string PersonalAddressKanjiCity { get; set; }

        [FormProperty("personal_address_kanji[country]")]
        public string PersonalAddressKanjiTwoLetterCountry { get; set; }

        [FormProperty("personal_address_kanji[line1]")]
        public string PersonalAddressKanjiLine1 { get; set; }

        [FormProperty("personal_address_kanji[line2]")]
        public string PersonalAddressKanjiLine2 { get; set; }

        [FormProperty("personal_address_kanji[postal_code]")]
        public string PersonalAddressKanjiPostalCode { get; set; }

        [FormProperty("personal_address_kanji[state]")]
        public string PersonalAddressKanjiState { get; set; }

        [FormProperty("personal_address_kanji[town]")]
        public string PersonalAddressKanjiTown { get; set; }

        #endregion

        [FormProperty("personal_id_number")]
        public string PersonalIdNumber { get; set; }

        [FormProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [FormProperty("ssn_last_4")]
        public string SSNLast4 { get; set; }

        [FormProperty("type")]
        public string Type { get; set; }

        #region Verification

        [FormProperty("verification[document]")]
        public string VerificationDocumentFileId { get; set; }

        [FormProperty("verification[document_back]")]
        public string VerificationDocumentFileBackId { get; set; }

        #endregion

        #region Additional Owners

        [FormProperty("additional_owners")]
        public List<AccountAdditionalOwner> AdditionalOwners { get; set; }

        #endregion
    }
}
