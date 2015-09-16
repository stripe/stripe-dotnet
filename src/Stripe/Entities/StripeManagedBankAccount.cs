using Newtonsoft.Json;

namespace Stripe.Entities
{
    public class StripeManagedBankAccount : StripeObject
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("routing_number")]
        public string RoutingNumber { get; set; }

        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        [JsonProperty("default_for_currency")]
        public bool DefaultForCurrency { get; set; }
    }
}
