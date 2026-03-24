// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentNextActionCryptoDisplayDetailsDepositAddressesSolanaSupportedToken : StripeEntity<PaymentIntentNextActionCryptoDisplayDetailsDepositAddressesSolanaSupportedToken>
    {
        /// <summary>
        /// The on-chain contract address for the supported token currency on this specific network.
        /// </summary>
        [JsonProperty("token_contract_address")]
        [STJS.JsonPropertyName("token_contract_address")]
        public string TokenContractAddress { get; set; }

        /// <summary>
        /// The supported token currency. Supported token currencies include: <c>usdc</c>.
        /// </summary>
        [JsonProperty("token_currency")]
        [STJS.JsonPropertyName("token_currency")]
        public string TokenCurrency { get; set; }
    }
}
