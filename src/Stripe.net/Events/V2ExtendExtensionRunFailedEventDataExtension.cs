// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2ExtendExtensionRunFailedEventDataExtension : StripeEntity<V2ExtendExtensionRunFailedEventDataExtension>,
        IHasId
    {
        /// <summary>
        /// The extension's unique identifier.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The extension method called where the failure occurred.
        /// </summary>
        [JsonProperty("method")]
        [STJS.JsonPropertyName("method")]
        public string Method { get; set; }

        /// <summary>
        /// Human-readable name of the extension.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Version of the extension that failed.
        /// </summary>
        [JsonProperty("version")]
        [STJS.JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
