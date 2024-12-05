// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerCashBalanceTransactionFundedBankTransferGbBankTransfer : StripeEntity<CustomerCashBalanceTransactionFundedBankTransferGbBankTransfer>
    {
        /// <summary>
        /// The last 4 digits of the account number of the sender of the funding.
        /// </summary>
        [JsonProperty("account_number_last4")]
        public string AccountNumberLast4 { get; set; }

        /// <summary>
        /// The full name of the sender, as supplied by the sending bank.
        /// </summary>
        [JsonProperty("sender_name")]
        public string SenderName { get; set; }

        /// <summary>
        /// The sort code of the bank of the sender of the funding.
        /// </summary>
        [JsonProperty("sort_code")]
        public string SortCode { get; set; }
    }
}
