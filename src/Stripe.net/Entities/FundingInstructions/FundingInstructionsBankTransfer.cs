// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class FundingInstructionsBankTransfer : StripeEntity<FundingInstructionsBankTransfer>
    {
        /// <summary>
        /// The country of the bank account to fund.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// A list of financial addresses that can be used to fund a particular balance.
        /// </summary>
        [JsonProperty("financial_addresses")]
        public List<FundingInstructionsBankTransferFinancialAddress> FinancialAddresses { get; set; }

        /// <summary>
        /// The bank_transfer type.
        /// One of: <c>eu_bank_transfer</c>, or <c>jp_bank_transfer</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
