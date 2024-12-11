// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressSortCode : StripeEntity<PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressSortCode>
    {
        [JsonProperty("account_holder_address")]
        public Address AccountHolderAddress { get; set; }

        /// <summary>
        /// The name of the person or business that owns the bank account.
        /// </summary>
        [JsonProperty("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The account number.
        /// </summary>
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("bank_address")]
        public Address BankAddress { get; set; }

        /// <summary>
        /// The six-digit sort code.
        /// </summary>
        [JsonProperty("sort_code")]
        public string SortCode { get; set; }
    }
}
