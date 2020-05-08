namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PersonUpdateOptions : BaseOptions, IHasMetadata
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

        [JsonProperty("person_token")]
        public string PersonToken { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("relationship")]
        public PersonRelationshipOptions Relationship { get; set; }

        [JsonProperty("ssn_last_4")]
        [AllowNameMismatch]
        public string SSNLast4 { get; set; }

        [JsonProperty("verification")]
        public PersonVerificationOptions Verification { get; set; }
    }
}
