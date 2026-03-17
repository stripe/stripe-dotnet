// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionCryptoDisplayDetailsDepositAddressesSolanaSupportedToken : StripeEntity<PaymentIntentNextActionCryptoDisplayDetailsDepositAddressesSolanaSupportedToken>
    {
        /// <summary>
        /// The on-chain contract address for the supported token currency on this specific network.
        /// </summary>
        [JsonProperty("token_contract_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("token_contract_address")]
#endif
        public string TokenContractAddress { get; set; }

        /// <summary>
        /// The supported token currency. Supported token currencies include: <c>usdc</c>.
        /// </summary>
        [JsonProperty("token_currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("token_currency")]
#endif
        public string TokenCurrency { get; set; }
    }
}
