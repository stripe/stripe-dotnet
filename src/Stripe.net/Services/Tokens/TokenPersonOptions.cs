namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TokenPersonOptions : INestedOptions, IHasMetadata
    {
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        [JsonProperty("address_kana")]
        public AddressJapanOptions AddressKana { get; set; }

        [JsonProperty("address_kanji")]
        public AddressJapanOptions AddressKanji { get; set; }

        [JsonProperty("dob")]
        public DobOptions Dob { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("first_name_kana")]
        public string FirstNameKana { get; set; }

        [JsonProperty("first_name_kanji")]
        public string FirstNameKanji { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("id_number")]
        public string IdNumber { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("last_name_kana")]
        public string LastNameKana { get; set; }

        [JsonProperty("last_name_kanji")]
        public string LastNameKanji { get; set; }

        [JsonProperty("maiden_name")]
        public string MaidenName { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("political_exposure")]
        public string PoliticalExposure { get; set; }

        [JsonProperty("relationship")]
        public TokenPersonRelationshipOptions Relationship { get; set; }

        [JsonProperty("ssn_last_4")]
        public string SsnLast4 { get; set; }

        [JsonProperty("verification")]
        public TokenPersonVerificationOptions Verification { get; set; }
    }
}
