// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderProcessConfigOptions : INestedOptions
    {
        /// <summary>
        /// Enables cancel button on transaction screens.
        /// </summary>
        [JsonProperty("enable_customer_cancellation")]
        public bool? EnableCustomerCancellation { get; set; }

        /// <summary>
        /// Override showing a tipping selection screen on this transaction.
        /// </summary>
        [JsonProperty("skip_tipping")]
        public bool? SkipTipping { get; set; }

        /// <summary>
        /// Tipping configuration for this transaction.
        /// </summary>
        [JsonProperty("tipping")]
        public ReaderProcessConfigTippingOptions Tipping { get; set; }
    }
}
