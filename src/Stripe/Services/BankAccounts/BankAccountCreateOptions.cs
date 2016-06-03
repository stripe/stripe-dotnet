using Newtonsoft.Json;
using System.Collections.Generic;

namespace Stripe
{
    public class BankAccountCreateOptions
    {
        [JsonProperty("source")]
        public string SourceToken { get; set; }

        [JsonProperty("source")]
        public SourceBankAccount SourceBankAccount { get; set; }
    }
}
