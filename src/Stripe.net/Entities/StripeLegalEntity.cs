using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeLegalEntity : StripeEntity
    {
        [JsonProperty("additional_owners")]
        public List<StripeAdditionalOwners> AdditionalOwners { get; set; }

        [JsonProperty("address")]
        public StripeAddress Address { get; set; }

        [JsonProperty("address_kana")]
        public StripeAddress AddressKana { get; set; }

        [JsonProperty("address_kanji")]
        public StripeAddress AddressKanji { get; set; }

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
        public StripeBirthDay BirthDay { get; set; }

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

        [JsonProperty("personal_address")]
        public StripeAddress PersonalAddress { get; set; }

        [JsonProperty("personal_address_kana")]
        public StripeAddress PersonalAddressKana { get; set; }

        [JsonProperty("personal_address_kanji")]
        public StripeAddress PersonalAddressKanji { get; set; }

        [JsonProperty("personal_id_number_provided")]
        public bool PersonalIdNumberProvided { get; set; }

        [JsonProperty("ssn_last_4_provided")]
        public bool SocialSecurityNumberLastFourProvided { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("verification")]
        public StripeLegalEntityVerification LegalEntityVerification { get; set; }
    }
}
