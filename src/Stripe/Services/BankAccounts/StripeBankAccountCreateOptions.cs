using Newtonsoft.Json;

namespace Stripe
{
    public class StripeBankAccountCreateOptions
    {
        [JsonProperty("bank_account")]
        public StripeBankAccountOptions BankAccount { get; set; }
    }
}
