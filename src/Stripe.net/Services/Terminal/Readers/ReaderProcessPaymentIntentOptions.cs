// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderProcessPaymentIntentOptions : BaseOptions
    {
        /// <summary>
        /// PaymentIntent ID.
        /// </summary>
        [JsonProperty("payment_intent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intent")]
#endif

        public string PaymentIntent { get; set; }

        /// <summary>
        /// Configuration overrides.
        /// </summary>
        [JsonProperty("process_config")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("process_config")]
#endif

        public ReaderProcessConfigOptions ProcessConfig { get; set; }
    }
}
