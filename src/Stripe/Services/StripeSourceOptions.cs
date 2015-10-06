using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Stripe
{
    public class StripeSourceOptions
    {
        [JsonProperty("source")]
        public string TokenId { get; set; }

        [JsonProperty("source[object]")]
        public string Object { get; set; }

        [JsonProperty("source[number]")]
        public string Number { get; set; }

        [JsonProperty("source[exp_month]")]
        public string ExpirationMonth { get; set; }

        [JsonProperty("source[exp_year]")]
        public string ExpirationYear { get; set; }

        [JsonProperty("source[cvc]")]
        public string Cvc { get; set; }

        [JsonProperty("source[name]")]
        public string Name { get; set; }

        [JsonProperty("source[address_line1]")]
        public string AddressLine1 { get; set; }

        [JsonProperty("source[address_line2]")]
        public string AddressLine2 { get; set; }

        [JsonProperty("source[address_city]")]
        public string AddressCity { get; set; }

        [JsonProperty("source[address_zip]")]
        public string AddressZip { get; set; }

        [JsonProperty("source[address_state]")]
        public string AddressState { get; set; }


    }
}
