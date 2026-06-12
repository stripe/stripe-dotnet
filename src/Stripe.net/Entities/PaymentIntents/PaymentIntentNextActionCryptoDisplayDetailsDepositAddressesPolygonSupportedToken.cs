// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentNextActionCryptoDisplayDetailsDepositAddressesPolygonSupportedToken : StripeEntity<PaymentIntentNextActionCryptoDisplayDetailsDepositAddressesPolygonSupportedToken>
    {
        /// <summary>
        /// The on-chain contract address for the supported token currency on this specific network.
        /// </summary>
        [JsonProperty("token_contract_address")]
        [STJS.JsonPropertyName("token_contract_address")]
        public string TokenContractAddress { get; set; }

        /// <summary>
        /// The supported token currency.
        /// One of: <c>usdc</c>, <c>usdg</c>, or <c>usdp</c>.
        /// </summary>
        [JsonProperty("token_currency")]
        [STJS.JsonPropertyName("token_currency")]
        public string TokenCurrency { get; set; }
    }
}
