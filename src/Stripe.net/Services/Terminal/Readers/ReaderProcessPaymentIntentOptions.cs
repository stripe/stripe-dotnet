// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderProcessPaymentIntentOptions : BaseOptions
    {
        /// <summary>
        /// PaymentIntent ID.
        /// </summary>
        [JsonProperty("payment_intent")]
        public string PaymentIntent { get; set; }

        /// <summary>
        /// Configuration overrides.
        /// </summary>
        [JsonProperty("process_config")]
        public ReaderProcessConfigOptions ProcessConfig { get; set; }
    }
}
