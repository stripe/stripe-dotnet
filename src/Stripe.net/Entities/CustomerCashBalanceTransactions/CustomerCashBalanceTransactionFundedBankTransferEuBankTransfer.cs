// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerCashBalanceTransactionFundedBankTransferEuBankTransfer : StripeEntity<CustomerCashBalanceTransactionFundedBankTransferEuBankTransfer>
    {
        /// <summary>
        /// The BIC of the bank of the sender of the funding.
        /// </summary>
        [JsonProperty("bic")]
        public string Bic { get; set; }

        /// <summary>
        /// The last 4 digits of the IBAN of the sender of the funding.
        /// </summary>
        [JsonProperty("iban_last4")]
        public string IbanLast4 { get; set; }

        /// <summary>
        /// The full name of the sender, as supplied by the sending bank.
        /// </summary>
        [JsonProperty("sender_name")]
        public string SenderName { get; set; }
    }
}
