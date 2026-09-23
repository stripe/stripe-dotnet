// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountWalletExportCredentialsWallet : StripeEntity<FinancialAccountWalletExportCredentialsWallet>
    {
        /// <summary>
        /// Public address of the exported wallet.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// Credentials encrypted to the supplied recipient public key.
        /// </summary>
        [JsonProperty("credentials_encrypted")]
        [STJS.JsonPropertyName("credentials_encrypted")]
        public FinancialAccountWalletExportCredentialsWalletCredentialsEncrypted CredentialsEncrypted { get; set; }

        /// <summary>
        /// Tempo network configured for each stablecoin currency. Keys are lowercase currency
        /// codes.
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
