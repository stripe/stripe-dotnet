namespace Stripe
{
    using Newtonsoft.Json;

    public class BankAccountCreateOptions : BaseOptions
    {
        [JsonProperty("source")]
        public string SourceToken { get; set; }

        [JsonProperty("source")]
        public SourceBankAccount SourceBankAccount { get; set; }
    }
}
