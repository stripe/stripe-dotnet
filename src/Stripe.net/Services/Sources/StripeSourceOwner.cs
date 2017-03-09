using Newtonsoft.Json;

namespace Stripe
{
    public class StripeSourceOwner : INestedOptions
    {
        [JsonProperty("[owner][address][city]")]
        public string CityOrTown { get; set; }

        [JsonProperty("[owner][address][country]")]
        public string Country { get; set; }

        [JsonProperty("[owner][address][line1]")]
        public string Line1 { get; set; }

        [JsonProperty("[owner][address][line2]")]
        public string Line2 { get; set; }

        [JsonProperty("[owner][address][postal_code]")]
        public string PostalCode { get; set; }

        [JsonProperty("[owner][address][state]")]
        public string State { get; set; }

        [JsonProperty("[owner][email]")]
        public string Email { get; set; }

        [JsonProperty("[owner][name]")]
        public string Name { get; set; }

        [JsonProperty("[owner][phone]")]
        public string Phone { get; set; }
    }
}
