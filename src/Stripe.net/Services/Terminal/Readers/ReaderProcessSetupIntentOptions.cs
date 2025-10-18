// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderProcessSetupIntentOptions : BaseOptions
    {
        /// <summary>
        /// This field indicates whether this payment method can be shown again to its customer in a
        /// checkout flow. Stripe products such as Checkout and Elements use this field to determine
        /// whether a payment method can be shown as a saved payment method in a checkout flow.
        /// One of: <c>always</c>, <c>limited</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("allow_redisplay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("allow_redisplay")]
#endif
        public string AllowRedisplay { get; set; }

        /// <summary>
        /// Configuration overrides for this setup, such as MOTO and customer cancellation settings.
        /// </summary>
        [JsonProperty("process_config")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("process_config")]
#endif
        public ReaderProcessConfigOptions ProcessConfig { get; set; }

        /// <summary>
        /// The ID of the SetupIntent to process on the reader.
        /// </summary>
        [JsonProperty("setup_intent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("setup_intent")]
#endif
        public string SetupIntent { get; set; }
    }
}
