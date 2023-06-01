// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerCashBalanceTransactionFundedBankTransfer : StripeEntity<CustomerCashBalanceTransactionFundedBankTransfer>
    {
        [JsonProperty("eu_bank_transfer")]
        public CustomerCashBalanceTransactionFundedBankTransferEuBankTransfer EuBankTransfer { get; set; }

        [JsonProperty("gb_bank_transfer")]
        public CustomerCashBalanceTransactionFundedBankTransferGbBankTransfer GbBankTransfer { get; set; }

        [JsonProperty("jp_bank_transfer")]
        public CustomerCashBalanceTransactionFundedBankTransferJpBankTransfer JpBankTransfer { get; set; }

        /// <summary>
        /// The user-supplied reference field on the bank transfer.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// The funding method type used to fund the customer balance. Permitted values include:
        /// <c>eu_bank_transfer</c>, <c>gb_bank_transfer</c>, <c>jp_bank_transfer</c>,
        /// <c>mx_bank_transfer</c>, or <c>us_bank_transfer</c>.
        /// One of: <c>eu_bank_transfer</c>, <c>gb_bank_transfer</c>, <c>jp_bank_transfer</c>,
        /// <c>mx_bank_transfer</c>, or <c>us_bank_transfer</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("us_bank_transfer")]
        public CustomerCashBalanceTransactionFundedBankTransferUsBankTransfer UsBankTransfer { get; set; }
    }
}
