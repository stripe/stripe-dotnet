// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundSetupIntentUpdatePayoutMethodDataOptions : INestedOptions
    {
        /// <summary>
        /// Closed Enum. The type of payout method to be created/updated.
        /// One of: <c>bank_account</c>, <c>card</c>, or <c>crypto_wallet</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// The type specific details of the bank account payout method.
        /// </summary>
        [JsonProperty("bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_account")]
#endif
        public OutboundSetupIntentUpdatePayoutMethodDataBankAccountOptions BankAccount { get; set; }

        /// <summary>
        /// The type specific details of the card payout method.
        /// </summary>
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public OutboundSetupIntentUpdatePayoutMethodDataCardOptions Card { get; set; }
    }
}
