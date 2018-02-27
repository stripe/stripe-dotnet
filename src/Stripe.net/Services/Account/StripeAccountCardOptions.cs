using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeAccountCardOptions : INestedOptions, ISupportMetadata
    {
        [JsonProperty("external_account[object]")]
        internal string Object => "card";

        [JsonProperty("external_account")]
        public string TokenId { get; set; }

        [JsonProperty("external_account[currency]")]
        public string Currency { get; set; }

        [JsonProperty("external_account[default_for_currency]")]
        public bool? DefaultForCurrency { get; set; }

        [JsonProperty("external_account[exp_month]")]
        public int? ExpirationMonth { get; set; }

        [JsonProperty("external_account[exp_year]")]
        public int? ExpirationYear { get; set; }

        [JsonProperty("external_account[number]")]
        public string Number { get; set; }

        [JsonProperty("external_account[address_city]")]
        public string AddressCity { get; set; }

        [JsonProperty("external_account[address_country]")]
        public string AddressCountry { get; set; }

        [JsonProperty("external_account[address_line1]")]
        public string AddressLine1 { get; set; }

        [JsonProperty("external_account[address_line2]")]
        public string AddressLine2 { get; set; }

        [JsonProperty("external_account[address_state]")]
        public string AddressState { get; set; }

        [JsonProperty("external_account[address_zip]")]
        public string AddressZip { get; set; }

        [JsonProperty("external_account[cvc]")]
        public string Cvc { get; set; }

        [JsonProperty("external_account[metadata]")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("external_account[name]")]
        public string Name { get; set; }
    }
}
