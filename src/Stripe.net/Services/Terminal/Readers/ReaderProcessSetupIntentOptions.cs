// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderProcessSetupIntentOptions : BaseOptions
    {
        /// <summary>
        /// This field indicates whether this payment method can be shown again to its customer in a
        /// checkout flow. Stripe products such as Checkout and Elements use this field to determine
        /// whether a payment method can be shown as a saved payment method in a checkout flow.
        /// One of: <c>always</c>, <c>limited</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("allow_redisplay")]
        public string AllowRedisplay { get; set; }

        /// <summary>
        /// Configuration overrides.
        /// </summary>
        [JsonProperty("process_config")]
        public ReaderProcessConfigOptions ProcessConfig { get; set; }

        /// <summary>
        /// SetupIntent ID.
        /// </summary>
        [JsonProperty("setup_intent")]
        public string SetupIntent { get; set; }
    }
}
