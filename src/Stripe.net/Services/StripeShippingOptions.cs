namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeShippingOptions : INestedOptions
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("address[city]")]
        public string CityOrTown { get; set; }

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
    }
}
