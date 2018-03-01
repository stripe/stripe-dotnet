using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class SourceBankAccount : INestedOptions, ISupportMetadata
    {
        [JsonProperty("source[object]")]
        internal string Object => "bank_account";

        [JsonProperty("source[account_holder_name]")]
        public string AccountHolderName { get; set; }

        [JsonProperty("source[account_holder_type]")]
        public string AccountHolderType { get; set; }

        [JsonProperty("source[account_number]")]
        public string AccountNumber { get; set; }

        [JsonProperty("source[bank_name]")]
        public string BankName { get; set; }

        [JsonProperty("source[country]")]
        public string Country { get; set; }

        [JsonProperty("source[currency]")]
        public string Currency { get; set; }

        [JsonProperty("source[metadata]")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("source[routing_number]")]
        public string RoutingNumber { get; set; }
    }
}