// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class FundingInstructionsBankTransferFinancialAddressSortCode : StripeEntity<FundingInstructionsBankTransferFinancialAddressSortCode>
    {
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

        /// <summary>
        /// The six-digit sort code.
        /// </summary>
        [JsonProperty("sort_code")]
        public string SortCode { get; set; }
    }
}
