// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderProcessSetupIntentOptions : BaseOptions
    {
        /// <summary>
        /// Customer Consent Collected.
        /// </summary>
        [JsonProperty("customer_consent_collected")]
        public bool? CustomerConsentCollected { get; set; }

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
