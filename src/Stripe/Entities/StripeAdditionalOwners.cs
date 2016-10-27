using Newtonsoft.Json;

namespace Stripe
{
    public class StripeAdditionalOwners : StripeEntity
    {
        [JsonProperty("address")]
        public StripeAddress Address { get; set; }

        [JsonProperty("dob")]
        public StripeBirthDay BirthDay { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("verification")]
        public StripeLegalEntityVerification LegalEntityVerification { get; set; }
    }
}