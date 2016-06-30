using Newtonsoft.Json;
using System.Collections.Generic;

namespace Stripe
{
    public class StripeAccountBankAccountOptions : INestedOptions
    {
        [JsonProperty("external_account[object]")]
        internal string Object { get { return "bank_account"; } }

        [JsonProperty("external_account")]
        public string TokenId { get; set; }

        [JsonProperty("external_account[account_number]")]
        public string AccountNumber { get; set; }

        [JsonProperty("external_account[country]")]
        public string Country { get; set; }

        [JsonProperty("external_account[currency]")]
        public string Currency { get; set; }

        [JsonProperty("external_account[account_holder_type]")]
        public string AccountHolderType { get; set; }

        [JsonProperty("external_account[name]")]
        public string Name { get; set; }

        [JsonProperty("external_account[routing_number]")]
        public string RoutingNumber { get; set; }
    }
}
