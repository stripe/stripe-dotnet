using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class CountrySpec : StripeObject
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        [JsonProperty("supported_bank_account_currencies")]
        public Dictionary<string, IEnumerable<string>> SupportedBankAccountCurrencies { get; set; }

        [JsonProperty("supported_payment_currencies")]
        public IEnumerable<string> SupportedPaymentCurrencies { get; set; }

        [JsonProperty("supported_payment_methods")]
        public IEnumerable<string> SupportedPaymentMethods { get; set; }

        [JsonProperty("verification_fields")]
        public Dictionary<string, Dictionary<string,List<string>>> VerificationFields { get; set; }
    }
}