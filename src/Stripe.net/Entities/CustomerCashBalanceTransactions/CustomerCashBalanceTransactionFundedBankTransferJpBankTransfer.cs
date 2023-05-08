// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerCashBalanceTransactionFundedBankTransferJpBankTransfer : StripeEntity<CustomerCashBalanceTransactionFundedBankTransferJpBankTransfer>
    {
        /// <summary>
        /// The name of the bank of the sender of the funding.
        /// </summary>
        [JsonProperty("sender_bank")]
        public string SenderBank { get; set; }

        /// <summary>
        /// The name of the bank branch of the sender of the funding.
        /// </summary>
        [JsonProperty("sender_branch")]
        public string SenderBranch { get; set; }

        /// <summary>
        /// The full name of the sender, as supplied by the sending bank.
        /// </summary>
        [JsonProperty("sender_name")]
        public string SenderName { get; set; }
    }
}
