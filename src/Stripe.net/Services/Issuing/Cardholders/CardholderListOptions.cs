namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderListOptions : StripeListOptions
    {
        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }

        [JsonProperty("email")]
        public int Email { get; set; }

        [JsonProperty("phone_number")]
        public int PhoneNumber { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
