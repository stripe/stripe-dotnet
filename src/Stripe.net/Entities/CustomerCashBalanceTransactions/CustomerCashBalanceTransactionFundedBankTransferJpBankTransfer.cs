// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerCashBalanceTransactionFundedBankTransferJpBankTransfer : StripeEntity<CustomerCashBalanceTransactionFundedBankTransferJpBankTransfer>
    {
        /// <summary>
        /// The name of the bank of the sender of the funding.
        /// </summary>
        [JsonProperty("sender_bank")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sender_bank")]
#endif

        public string SenderBank { get; set; }

        /// <summary>
        /// The name of the bank branch of the sender of the funding.
        /// </summary>
        [JsonProperty("sender_branch")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sender_branch")]
#endif

        public string SenderBranch { get; set; }

        /// <summary>
        /// The full name of the sender, as supplied by the sending bank.
        /// </summary>
        [JsonProperty("sender_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sender_name")]
#endif

        public string SenderName { get; set; }
    }
}
