// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ConfigurationStripeS700Options : INestedOptions
    {
        /// <summary>
        /// A File ID representing an image you would like displayed on the reader.
        /// </summary>
        [JsonProperty("splashscreen")]
        public string Splashscreen { get; set; }
    }
}
