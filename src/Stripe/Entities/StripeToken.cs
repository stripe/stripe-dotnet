using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeToken : StripeObject
    {
        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? Created { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("used")]
        public bool? Used { get; set; }
        
        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("card")]
        public StripeCard StripeCard { get; set; }

        [JsonProperty("bank_account[id]")]
        public string BankAccountId { get; set; }

        [JsonProperty("bank_account[object]")]
        public string BankAccountObject { get; set; }

        [JsonProperty("bank_account[bank_name]")]
        public string BankAccountName { get; set; }

        [JsonProperty("bank_account[country]")]
        public string BankAccountCountry { get; set; }

        [JsonProperty("bank_account[currency]")]
        public string BankAccountCurrency { get; set; }

        [JsonProperty("bank_account[last4]")]
        public string BankAccountLast4 { get; set; }

        [JsonProperty("bank_account[fingerprint]")]
        public string BankAccountFingerprint { get; set; }

        [JsonProperty("bank_account[validated]")]
        public bool? BankAccountValidated { get; set; }

        [JsonProperty("bank_account[verified]")]
        public bool? BankAccountVerified { get; set; }
    }
}