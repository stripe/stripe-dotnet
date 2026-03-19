// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfigurationVerifoneP400Options : INestedOptions
    {
        /// <summary>
        /// A File ID representing an image you want to display on the reader.
        /// </summary>
        [JsonProperty("splashscreen")]
        [STJS.JsonPropertyName("splashscreen")]
        public string Splashscreen { get; set; }
    }
}
