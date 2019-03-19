namespace Stripe
{
    using Newtonsoft.Json;

    public class BillingDetails : StripeEntity
    {
        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
