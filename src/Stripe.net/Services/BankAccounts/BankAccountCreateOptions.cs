using Newtonsoft.Json;

namespace Stripe
{
    public class BankAccountCreateOptions : StripeBaseOptions
    {
        [JsonProperty("source")]
        public string SourceToken { get; set; }

        [JsonProperty("source")]
        public SourceBankAccount SourceBankAccount { get; set; }
    }
}
