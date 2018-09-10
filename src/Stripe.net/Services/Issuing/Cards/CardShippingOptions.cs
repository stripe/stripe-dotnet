namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardShippingOptions : INestedOptions
    {
        [JsonProperty("address[city]")]
        public string City { get; set; }

        [JsonProperty("address[country]")]
        public string Country { get; set; }

        [JsonProperty("address[line1]")]
        public string Line1 { get; set; }

        [JsonProperty("address[line2]")]
        public string Line2 { get; set; }

        [JsonProperty("address[postal_code]")]
        public string PostalCode { get; set; }

        [JsonProperty("address[state]")]
        public string State { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
