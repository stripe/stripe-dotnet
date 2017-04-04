using Newtonsoft.Json;

namespace Stripe
{
    public class StripeIdeal : StripeEntity
    {
        [JsonProperty("bank")]
        public string Bank { get; set; }

        [JsonProperty("bic")]
        public string Bic { get; set; }

        [JsonProperty("iban_last4")]
        public string IbanLast4 { get; set; }
    }
} 
