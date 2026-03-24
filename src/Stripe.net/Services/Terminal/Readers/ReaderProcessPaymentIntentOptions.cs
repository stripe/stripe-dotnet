// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReaderProcessPaymentIntentOptions : BaseOptions
    {
        /// <summary>
        /// The ID of the PaymentIntent to process on the reader.
        /// </summary>
        [JsonProperty("payment_intent")]
        [STJS.JsonPropertyName("payment_intent")]
        public string PaymentIntent { get; set; }

        /// <summary>
        /// Configuration overrides for this transaction, such as tipping and customer cancellation
        /// settings.
        /// </summary>
        [JsonProperty("process_config")]
        [STJS.JsonPropertyName("process_config")]
        public ReaderProcessConfigOptions ProcessConfig { get; set; }
    }
}
