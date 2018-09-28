namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountAdditionalOwner : INestedOptions
    {
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        [JsonProperty("dob")]
        public AccountDobOptions Dob { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("verification")]
        public AccountVerificationOptions Verification { get; set; }
    }
}
