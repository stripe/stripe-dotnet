namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceOwner : StripeEntity<SourceOwner>
    {
        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("verified_address")]
        public Address VerifiedAddress { get; set; }

        [JsonProperty("verified_email")]
        public string VerifiedEmail { get; set; }

        [JsonProperty("verified_name")]
        public string VerifiedName { get; set; }

        [JsonProperty("verified_phone")]
        public string VerifiedPhone { get; set; }
    }
}
