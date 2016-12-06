using Newtonsoft.Json;

namespace Stripe
{
    public class StripeAccountAdditionalOwner : INestedOptions
    {
        // it looks like additional owners doesn't update quite the same way, as far as first_name at least.
        // Or it doesn't work like metadata were you just replace the whole object. However, it doesn't add a new additional user anyway. 
        // Something to be aware of, but edge case. Also, the date of birth doesn't appear to map the same way in the two objects? Needs more 
        // research, but since stripe.net uses the same class for this, it's weird.

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
