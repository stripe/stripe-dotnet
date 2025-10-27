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
        /// The ID of the PaymentIntent to process on the reader.
        /// </summary>
        [JsonProperty("payment_intent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intent")]
#endif
        public string PaymentIntent { get; set; }

        /// <summary>
        /// Configuration overrides for this transaction, such as tipping and customer cancellation
        /// settings.
        /// </summary>
        [JsonProperty("process_config")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("process_config")]
#endif
        public ReaderProcessConfigOptions ProcessConfig { get; set; }
    }
}
