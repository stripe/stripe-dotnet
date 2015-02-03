using Newtonsoft.Json;

namespace Stripe
{
    public class BankAccountOptions
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("routing_number")]
        public string RoutingNumber { get; set; }

        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }
    }
}