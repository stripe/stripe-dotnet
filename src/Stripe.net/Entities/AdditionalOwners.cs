namespace Stripe
{
    using Newtonsoft.Json;

    public class AdditionalOwners : StripeEntity
    {
        [JsonProperty("address")]
        public StripeAddress Address { get; set; }

        [JsonProperty("dob")]
        public BirthDay BirthDay { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("verification")]
        public LegalEntityVerification LegalEntityVerification { get; set; }
    }
}