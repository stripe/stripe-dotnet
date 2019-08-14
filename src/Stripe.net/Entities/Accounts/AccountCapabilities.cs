namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class AccountCapabilities : StripeEntity<AccountCapabilities>
    {
        /// <summary>
        /// The status of the card payments capability of the account, or whether the account can
        /// directly process credit and debit card charges.
        /// </summary>
        [JsonProperty("card_payments")]
        public string CardPayments { get; set; }

        /// <summary>
        /// The status of the legacy payments capability of the account.
        /// </summary>
        [JsonProperty("legacy_payments")]
        public string LegacyPayments { get; set; }

        /// <summary>
        /// The status of the transfers capability of the account, or whether your platform can
        /// transfer funds to the account.
        /// </summary>
        [JsonProperty("transfers")]
        public string Transfers { get; set; }
    }
}
