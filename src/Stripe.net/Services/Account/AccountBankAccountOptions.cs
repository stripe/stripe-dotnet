namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class AccountBankAccountOptions : INestedOptions
    {
        [JsonProperty("object")]
        internal string Object => "bank_account";

        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("account_holder_type")]
        public string AccountHolderType { get; set; }

        [JsonProperty("account_holder_name")]
        public string AccountHolderName { get; set; }

        [JsonProperty("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
