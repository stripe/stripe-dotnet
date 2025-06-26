// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderCollectPaymentMethodOptions : BaseOptions
    {
        /// <summary>
        /// Configuration overrides.
        /// </summary>
        [JsonProperty("collect_config")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collect_config")]
#endif
        public ReaderCollectConfigOptions CollectConfig { get; set; }

        /// <summary>
        /// PaymentIntent ID.
        /// </summary>
        [JsonProperty("payment_intent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intent")]
#endif
        public string PaymentIntent { get; set; }
    }
}
