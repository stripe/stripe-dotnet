// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class FundingInstructionsBankTransferFinancialAddressSpei : StripeEntity<FundingInstructionsBankTransferFinancialAddressSpei>
    {
        [JsonProperty("account_holder_address")]
        public Address AccountHolderAddress { get; set; }

        /// <summary>
        /// The account holder name.
        /// </summary>
        [JsonProperty("account_holder_name")]
        public string AccountHolderName { get; set; }

        [JsonProperty("bank_address")]
        public Address BankAddress { get; set; }

        /// <summary>
        /// The three-digit bank code.
        /// </summary>
        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// The short banking institution name.
        /// </summary>
        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// The CLABE number.
        /// </summary>
        [JsonProperty("clabe")]
        public string Clabe { get; set; }
    }
}
