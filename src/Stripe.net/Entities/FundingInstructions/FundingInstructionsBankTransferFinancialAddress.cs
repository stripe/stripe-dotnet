// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class FundingInstructionsBankTransferFinancialAddress : StripeEntity<FundingInstructionsBankTransferFinancialAddress>
    {
        /// <summary>
        /// The payment networks supported by this FinancialAddress.
        /// </summary>
        [JsonProperty("supported_networks")]
        public List<string> SupportedNetworks { get; set; }

        /// <summary>
        /// The type of financial address.
        /// One of: <c>iban</c>, or <c>zengin</c>.
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
