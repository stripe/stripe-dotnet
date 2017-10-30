using Newtonsoft.Json;

namespace Stripe
{
    public class StripeSourceAchCreditTransfer : StripeEntity
    {
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("routing_number")]
        public string RoutingNumber { get; set; }

        [JsonProperty("swift_code")]
        public string SwiftCode { get; set; }
    }
} 
