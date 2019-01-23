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
        /// The status of the platform payments capability of the account, or whether your platform
        /// can process charges on behalf of the account.
        /// </summary>
        [JsonProperty("platform_payments")]
        public string PlatformPayments { get; set; }
    }
}
