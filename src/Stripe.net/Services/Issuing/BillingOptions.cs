namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class BillingOptions : INestedOptions
    {
        [JsonProperty("billing[address][city]")]
        public string City { get; set; }

        [JsonProperty("billing[address][country]")]
        public string Country { get; set; }

        [JsonProperty("billing[address][line1]")]
        public string Line1 { get; set; }

        [JsonProperty("billing[address][line2]")]
        public string Line2 { get; set; }

        [JsonProperty("billing[address][postal_code]")]
        public string PostalCode { get; set; }

        [JsonProperty("billing[address][state]")]
        public string State { get; set; }

        // Keep this one separate as it's not on the same level in the API.
        [JsonProperty("billing[name]")]
        public string Name { get; set; }
    }
}
