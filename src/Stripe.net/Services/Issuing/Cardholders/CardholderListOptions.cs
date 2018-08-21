namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderListOptions : ListOptions
    {
        [JsonProperty("created")]
        public DateFilter Created { get; set; }

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
