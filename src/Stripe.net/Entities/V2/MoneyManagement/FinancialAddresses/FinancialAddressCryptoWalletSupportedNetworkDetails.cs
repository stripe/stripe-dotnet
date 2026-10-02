// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAddressCryptoWalletSupportedNetworkDetails : StripeEntity<FinancialAddressCryptoWalletSupportedNetworkDetails>
    {
        /// <summary>
        /// The token currencies supported on this network.
        /// One of: <c>btc</c>, <c>eth</c>, <c>sol</c>, <c>usdc</c>, or <c>usdt</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("supported_token_currencies")]
        [STJS.JsonPropertyName("supported_token_currencies")]
        public List<string> SupportedTokenCurrencies { get; set; }
    }
}
