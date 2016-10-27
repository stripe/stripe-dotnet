using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class CountrySpec : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        [JsonProperty("supported_bank_account_currencies")]
        public Dictionary<string, List<string>> SupportedBankAccountCurrencies { get; set; }

        [JsonProperty("supported_payment_currencies")]
        public List<string> SupportedPaymentCurrencies { get; set; }

        [JsonProperty("supported_payment_methods")]
        public List<string> SupportedPaymentMethods { get; set; }

        [JsonProperty("verification_fields")]
        public Dictionary<string, Dictionary<string, List<string>>> VerificationFields { get; set; }
    }
}