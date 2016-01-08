using Newtonsoft.Json;

namespace Stripe
{
    public class StripeAdditionalOwners
    {
        [JsonProperty("address")]
        public StripeAddress Address { get; set; }

        [JsonProperty("dob")]
        public StripeBirthDay StripeBirthDay { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("verification")]
        public StripeLegalEntityVerification Verification { get; set; }
    }
}