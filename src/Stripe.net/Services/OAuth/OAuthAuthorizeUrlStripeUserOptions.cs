namespace Stripe
{
    using Newtonsoft.Json;

    public class OAuthAuthorizeUrlStripeUserOptions : INestedOptions
    {
        [JsonProperty("block_kana")]
        public string BlockKana { get; set; }

        [JsonProperty("block_kanji")]
        public string BlockKanji { get; set; }

        [JsonProperty("building_kana")]
        public string BuildingKana { get; set; }

        [JsonProperty("building_kanji")]
        public string BuildingKanji { get; set; }

        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        [JsonProperty("business_type")]
        public string BusinessType { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("dob_day")]
        public long? DobDay { get; set; }

        [JsonProperty("dob_month")]
        public long? DobMonth { get; set; }

        [JsonProperty("dob_year")]
        public long? DobYear { get; set; }

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

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("last_name_kana")]
        public string LastNameKana { get; set; }

        [JsonProperty("last_name_kanji")]
        public string LastNameKanji { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("physical_product")]
        public bool? PhysicalProduct { get; set; }

        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("street_address")]
        public string StreetAddress { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }
}
