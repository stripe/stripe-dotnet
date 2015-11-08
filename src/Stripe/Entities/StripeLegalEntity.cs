using Newtonsoft.Json;

namespace Stripe
{
    public class StripeLegalEntity
    {
        //list
        [JsonProperty("additional_owners")]
        public StripeList<StripeAdditionalOwner> StripAdditionalOwnerList { get; set; }

        //hash
        [JsonProperty("address")]
        public StripeAddress Address { get; set; }

        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        //hash
        [JsonProperty("dob")]
        public StripeDOB DOB { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        //hash
        [JsonProperty("personal_address")]
        public StripeAddress PersonalAddress { get; set; }

        [JsonProperty("personal_id_number_provided")]
        public bool PersonalIdNumberProvided { get; set; }

        [JsonProperty("ssn_last_4_provided")]
        public bool SSNLast4Provided { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        //hash
        [JsonProperty("verification")]
        public StripeVerificationOfEntity Verification { get; set; }
    }
}
