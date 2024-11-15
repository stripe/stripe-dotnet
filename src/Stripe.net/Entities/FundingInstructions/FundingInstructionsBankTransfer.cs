// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FundingInstructionsBankTransfer : StripeEntity<FundingInstructionsBankTransfer>
    {
        /// <summary>
        /// The country of the bank account to fund.
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif

        public string Country { get; set; }

        /// <summary>
        /// A list of financial addresses that can be used to fund a particular balance.
        /// </summary>
        [JsonProperty("financial_addresses")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_addresses")]
#endif

        public List<FundingInstructionsBankTransferFinancialAddress> FinancialAddresses { get; set; }

        /// <summary>
        /// The bank_transfer type.
        /// One of: <c>eu_bank_transfer</c>, or <c>jp_bank_transfer</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }
    }
}
