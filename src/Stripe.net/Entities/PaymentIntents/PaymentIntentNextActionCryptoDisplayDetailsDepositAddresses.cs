// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionCryptoDisplayDetailsDepositAddresses : StripeEntity<PaymentIntentNextActionCryptoDisplayDetailsDepositAddresses>
    {
        [JsonProperty("base")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("base")]
#endif
        public PaymentIntentNextActionCryptoDisplayDetailsDepositAddressesBase Base { get; set; }

        [JsonProperty("solana")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("solana")]
#endif
        public PaymentIntentNextActionCryptoDisplayDetailsDepositAddressesSolana Solana { get; set; }

        [JsonProperty("tempo")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tempo")]
#endif
        public PaymentIntentNextActionCryptoDisplayDetailsDepositAddressesTempo Tempo { get; set; }
    }
}
