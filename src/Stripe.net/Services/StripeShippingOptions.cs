using Newtonsoft.Json;

namespace Stripe
{
    public class StripeShippingOptions : INestedOptions
    {
        [JsonProperty("shipping[name]")]
        public string Name { get; set; }

        [JsonProperty("shipping[phone]")]
        public string Phone { get; set; }

        [JsonProperty("shipping[address][city]")]
        public string CityOrTown { get; set; }

        [JsonProperty("shipping[address][country]")]
        public string Country { get; set; }

        [JsonProperty("shipping[address][line1]")]
        public string Line1 { get; set; }

        [JsonProperty("shipping[address][line2]")]
        public string Line2 { get; set; }

        [JsonProperty("shipping[address][postal_code]")]
        public string PostalCode { get; set; }

        [JsonProperty("shipping[address][state]")]
        public string State { get; set; }
    }
}
