using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeAccountLegalEntityOptions 
    {
        [JsonProperty("legal_entity[dob][day]")]
        public string Day { get; set; }

        [JsonProperty("legal_entity[dob][month]")]
        public string Month { get; set; }

        [JsonProperty("legal_entity[dob][year]")]
        public string Year { get; set; }
       
        [JsonProperty("legal_entity[first_name]")]
        public string FistName { get; set; }

        [JsonProperty("legal_entity[last_name]")]
        public string LastName { get; set; }

        [JsonProperty("legal_entity[type]")]
        public string Type { get; set; }
    }
}
