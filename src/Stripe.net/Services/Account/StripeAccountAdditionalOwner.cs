using Newtonsoft.Json;

namespace Stripe
{
    public class StripeAccountAdditionalOwner : INestedOptions
    {
        [JsonProperty("[city]")]
        public string City { get; set; }

        [JsonProperty("[country]")]
        public string Country { get; set; }

        [JsonProperty("[line1]")]
        public string Line1 { get; set; }

        [JsonProperty("[line2]")]
        public string Line2 { get; set; }

        [JsonProperty("[postal_code]")]
        public string PostalCode { get; set; }

        [JsonProperty("[state]")]
        public string State { get; set; }

        //[JsonProperty("[dob][day]")]
        //public int? BirthDay { get; set; }

        //[JsonProperty("[dob][month]")]
        //public int? BirthMonth { get; set; }

        //[JsonProperty("[dob][year]")]
        //public int? BirthYear { get; set; }

        [JsonProperty("[first_name]")]
        public string FirstName { get; set; }

        [JsonProperty("[last_name]")]
        public string LastName { get; set; }
    }
}
