// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerCashBalanceTransactionFundedBankTransferGbBankTransfer : StripeEntity<CustomerCashBalanceTransactionFundedBankTransferGbBankTransfer>
    {
        /// <summary>
        /// The last 4 digits of the account number of the sender of the funding.
        /// </summary>
        [JsonProperty("account_number_last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_number_last4")]
#endif

        public string AccountNumberLast4 { get; set; }

        /// <summary>
        /// The full name of the sender, as supplied by the sending bank.
        /// </summary>
        [JsonProperty("sender_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sender_name")]
#endif

        public string SenderName { get; set; }

        /// <summary>
        /// The sort code of the bank of the sender of the funding.
        /// </summary>
        [JsonProperty("sort_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sort_code")]
#endif

        public string SortCode { get; set; }
    }
}
