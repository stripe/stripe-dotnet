using Newtonsoft.Json;

namespace Stripe
{
    public abstract class BankAccountDebitCardOptions : CreditCardOptions
    {
        [JsonProperty(Properties.BANK_ACCOUNT_COUNTRY)]
        public string BankAccountCountry { get; set; }

        [JsonProperty(Properties.BANK_ACCOUNT_ROUTING_NUMBER)]
        public string BankAccountRoutingNumber { get; set; }

        [JsonProperty(Properties.BANK_ACCOUNT_ACCOUNT_NUMBER)]
        public string BankAccountNumber { get; set; }
    }
}
