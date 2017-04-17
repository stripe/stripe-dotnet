using Newtonsoft.Json;

namespace Stripe
{
    public class StripeSepaDebit : StripeEntity
    {
        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("mandate_reference")]
        public string MandateReference { get; set; }

        [JsonProperty("mandate_url")]
        public string MandateUrl { get; set; }
    }
}
