// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class FinancialAccountFinancialAddress : StripeEntity<FinancialAccountFinancialAddress>
    {
        /// <summary>
        /// ABA Records contain U.S. bank account details per the ABA format.
        /// </summary>
        [JsonProperty("aba")]
        public FinancialAccountFinancialAddressAba Aba { get; set; }

        /// <summary>
        /// The list of networks that the address supports.
        /// </summary>
        [JsonProperty("supported_networks")]
        public List<string> SupportedNetworks { get; set; }

        /// <summary>
        /// The type of financial address.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
