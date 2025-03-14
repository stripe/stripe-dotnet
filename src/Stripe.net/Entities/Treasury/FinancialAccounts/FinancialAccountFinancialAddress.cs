// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountFinancialAddress : StripeEntity<FinancialAccountFinancialAddress>
    {
        /// <summary>
        /// ABA Records contain U.S. bank account details per the ABA format.
        /// </summary>
        [JsonProperty("aba")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("aba")]
#endif
        public FinancialAccountFinancialAddressAba Aba { get; set; }

        /// <summary>
        /// The list of networks that the address supports.
        /// One of: <c>ach</c>, or <c>us_domestic_wire</c>.
        /// </summary>
        [JsonProperty("supported_networks")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("supported_networks")]
#endif
        public List<string> SupportedNetworks { get; set; }

        /// <summary>
        /// The type of financial address.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
