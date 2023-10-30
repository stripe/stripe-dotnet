// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class FundingInstructionsBankTransferFinancialAddress : StripeEntity<FundingInstructionsBankTransferFinancialAddress>
    {
        /// <summary>
        /// Iban Records contain E.U. bank account details per the SEPA format.
        /// </summary>
        [JsonProperty("iban")]
        public FundingInstructionsBankTransferFinancialAddressIban Iban { get; set; }

        /// <summary>
        /// Sort Code Records contain U.K. bank account details per the sort code format.
        /// </summary>
        [JsonProperty("sort_code")]
        public FundingInstructionsBankTransferFinancialAddressSortCode SortCode { get; set; }

        /// <summary>
        /// SPEI Records contain Mexico bank account details per the SPEI format.
        /// </summary>
        [JsonProperty("spei")]
        public FundingInstructionsBankTransferFinancialAddressSpei Spei { get; set; }

        /// <summary>
        /// The payment networks supported by this FinancialAddress.
        /// One of: <c>bacs</c>, <c>fps</c>, <c>sepa</c>, <c>spei</c>, or <c>zengin</c>.
        /// </summary>
        [JsonProperty("supported_networks")]
        public List<string> SupportedNetworks { get; set; }

        /// <summary>
        /// The type of financial address.
        /// One of: <c>iban</c>, <c>sort_code</c>, <c>spei</c>, or <c>zengin</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Zengin Records contain Japan bank account details per the Zengin format.
        /// </summary>
        [JsonProperty("zengin")]
        public FundingInstructionsBankTransferFinancialAddressZengin Zengin { get; set; }
    }
}
