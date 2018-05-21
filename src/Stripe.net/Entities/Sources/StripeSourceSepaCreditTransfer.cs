using Newtonsoft.Json;

namespace Stripe
{
    public class StripeSourceSepaCreditTransfer : StripeEntity
    {
        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        [JsonProperty("iban")]
        public string Iban { get; set; }

        [JsonProperty("swift_code")]
        public string SwiftCode { get; set; }
    }
} 
