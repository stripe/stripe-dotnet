namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class AccountCapabilities : StripeEntity<AccountCapabilities>
    {
        [JsonProperty("card_payments")]
        public string CardPayments { get; set; }

        [JsonProperty("legacy_payments")]
        public string LegacyPayments { get; set; }

        [JsonProperty("transfers")]
        public string Transfers { get; set; }
    }
}
