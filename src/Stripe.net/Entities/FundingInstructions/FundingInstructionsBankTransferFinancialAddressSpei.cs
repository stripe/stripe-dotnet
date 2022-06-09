// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class FundingInstructionsBankTransferFinancialAddressSpei : StripeEntity<FundingInstructionsBankTransferFinancialAddressSpei>
    {
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
