using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeSourceOwner : INestedOptions
    {
        [JsonProperty("[owner][city]")]
        public string CityOrTown { get; set; }

        [JsonProperty("[owner][country]")]
        public string Country { get; set; }

        [JsonProperty("[owner][line1]")]
        public string Line1 { get; set; }

        [JsonProperty("[owner][line2]")]
        public string Line2 { get; set; }

        [JsonProperty("[owner][postal_code]")]
        public string PostalCode { get; set; }

        [JsonProperty("[owner][state]")]
        public string State { get; set; }

        [JsonProperty("[owner][email]")]
        public string Email { get; set; }

        [JsonProperty("[owner][name]")]
        public string Name { get; set; }

        [JsonProperty("[owner][phone]")]
        public string Phone { get; set; }
    }
}