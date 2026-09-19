// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountWalletExportWallet : StripeEntity<FinancialAccountWalletExportWallet>
    {
        /// <summary>
        /// Public address of the exported wallet.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// Network on which each stablecoin currency is stored. Keys are lowercase currency codes.
        /// One of: <c>tempo</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("currency_networks")]
        [STJS.JsonPropertyName("currency_networks")]
        public Dictionary<string, string> CurrencyNetworks { get; set; }

        /// <summary>
        /// Network family for the wallet address.
        /// One of: <c>ethereum</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("network_type")]
        [STJS.JsonPropertyName("network_type")]
        public string NetworkType { get; set; }
    }
}
