// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMoneyManagerCapabilitiesReceivedCreditsOnrampOptions : INestedOptions
    {
        /// <summary>
        /// Crypto wallets for fiat converted into crypto.
        /// </summary>
        [JsonProperty("crypto_wallets")]
        [STJS.JsonPropertyName("crypto_wallets")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesReceivedCreditsOnrampCryptoWalletsOptions CryptoWallets { get; set; }
    }
}
