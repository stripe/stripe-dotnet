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
        public StripeDOB DOB { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        //hash
        [JsonProperty("verification")]
        public StripeVerificationOfEntity Verification { get; set; }

    }
}