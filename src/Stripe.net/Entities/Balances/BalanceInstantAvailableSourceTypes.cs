// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class BalanceInstantAvailableSourceTypes : StripeEntity<BalanceInstantAvailableSourceTypes>
    {
        /// <summary>
        /// Amount for bank account.
        /// </summary>
        [JsonProperty("bank_account")]
        public long BankAccount { get; set; }

        /// <summary>
        /// Amount for card.
        /// </summary>
        [JsonProperty("card")]
        public long Card { get; set; }

        /// <summary>
        /// Amount for FPX.
        /// </summary>
        [JsonProperty("fpx")]
        public long Fpx { get; set; }
    }
}
