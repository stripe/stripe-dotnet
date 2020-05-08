namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CountrySpec : StripeEntity<CountrySpec>, IHasId, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

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

        [JsonProperty("supported_transfer_countries")]
        public List<string> SupportedTransferCountries { get; set; }

        [JsonProperty("verification_fields")]
        public CountrySpecVerificationFields VerificationFields { get; set; }
    }
}
