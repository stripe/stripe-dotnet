using Newtonsoft.Json;

namespace Stripe
{
    public class StripeAdditionalOwner : StripeObject
    {
        //hash
        [JsonProperty("address")]
        public StripeAddress Address { get; set; }

        //hash
        [JsonProperty("dob")]
        public StripeDob Dob { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        //hash
        [JsonProperty("verification")]
        public StripeLegalEntityVerification Verification { get; set; }

    }
}