// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BalanceInstantAvailableSourceTypes : StripeEntity<BalanceInstantAvailableSourceTypes>
    {
        /// <summary>
        /// Amount for bank account.
        /// </summary>
        [JsonProperty("bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_account")]
#endif
        public long BankAccount { get; set; }

        /// <summary>
        /// Amount for card.
        /// </summary>
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public long Card { get; set; }

        /// <summary>
        /// Amount for FPX.
        /// </summary>
        [JsonProperty("fpx")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fpx")]
#endif
        public long Fpx { get; set; }
    }
}
