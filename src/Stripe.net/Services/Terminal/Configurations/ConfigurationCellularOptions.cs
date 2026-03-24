// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfigurationCellularOptions : INestedOptions
    {
        /// <summary>
        /// Determines whether to allow the reader to connect to a cellular network. Defaults to
        /// false.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
    }
}
