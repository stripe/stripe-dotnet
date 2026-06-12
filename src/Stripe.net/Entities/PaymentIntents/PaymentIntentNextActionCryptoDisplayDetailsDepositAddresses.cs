// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentNextActionCryptoDisplayDetailsDepositAddresses : StripeEntity<PaymentIntentNextActionCryptoDisplayDetailsDepositAddresses>
    {
        [JsonProperty("base")]
        [STJS.JsonPropertyName("base")]
        public PaymentIntentNextActionCryptoDisplayDetailsDepositAddressesBase Base { get; set; }

        [JsonProperty("ethereum")]
        [STJS.JsonPropertyName("ethereum")]
        public PaymentIntentNextActionCryptoDisplayDetailsDepositAddressesEthereum Ethereum { get; set; }

        [JsonProperty("polygon")]
        [STJS.JsonPropertyName("polygon")]
        public PaymentIntentNextActionCryptoDisplayDetailsDepositAddressesPolygon Polygon { get; set; }

        [JsonProperty("solana")]
        [STJS.JsonPropertyName("solana")]
        public PaymentIntentNextActionCryptoDisplayDetailsDepositAddressesSolana Solana { get; set; }

        [JsonProperty("tempo")]
        [STJS.JsonPropertyName("tempo")]
        public PaymentIntentNextActionCryptoDisplayDetailsDepositAddressesTempo Tempo { get; set; }
    }
}
