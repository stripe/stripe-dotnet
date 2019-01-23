namespace Stripe
{
    using Newtonsoft.Json;

    public class AdditionalOwner : StripeEntity<AdditionalOwner>
    {
        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("dob")]
        public BirthDay Dob { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("maiden_name")]
        public string MaidenName { get; set; }

        [JsonProperty("personal_id_number_provided")]
        public bool PersonalIdNumberProvided { get; set; }

        [JsonProperty("verification")]
        public LegalEntityVerification Verification { get; set; }
    }
}
