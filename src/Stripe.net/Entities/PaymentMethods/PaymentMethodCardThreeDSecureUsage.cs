// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentMethodCardThreeDSecureUsage : StripeEntity<PaymentMethodCardThreeDSecureUsage>
    {
        /// <summary>
        /// Whether 3D Secure is supported on this card.
        /// </summary>
        [JsonProperty("supported")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("supported")]
#endif
        public bool Supported { get; set; }
    }
}
