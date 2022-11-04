// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderProcessConfigOptions : INestedOptions
    {
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
