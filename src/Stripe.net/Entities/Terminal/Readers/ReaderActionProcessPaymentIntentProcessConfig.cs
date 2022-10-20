// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderActionProcessPaymentIntentProcessConfig : StripeEntity<ReaderActionProcessPaymentIntentProcessConfig>
    {
        /// <summary>
        /// Override showing a tipping selection screen on this transaction.
        /// </summary>
        [JsonProperty("skip_tipping")]
        public bool SkipTipping { get; set; }

        /// <summary>
        /// Represents a per-transaction tipping configuration.
        /// </summary>
        [JsonProperty("tipping")]
        public ReaderActionProcessPaymentIntentProcessConfigTipping Tipping { get; set; }
    }
}
