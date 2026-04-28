// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2ExtendExtensionRunFailedEventData : StripeEntity<V2ExtendExtensionRunFailedEventData>
    {
        /// <summary>
        /// Details about the error that occurred.
        /// </summary>
        [JsonProperty("error")]
        [STJS.JsonPropertyName("error")]
        public V2ExtendExtensionRunFailedEventDataError Error { get; set; }

        /// <summary>
        /// Details about the extension that failed.
        /// </summary>
        [JsonProperty("extension")]
        [STJS.JsonPropertyName("extension")]
        public V2ExtendExtensionRunFailedEventDataExtension Extension { get; set; }

        /// <summary>
        /// The ID of the extension run that failed.
        /// </summary>
        [JsonProperty("extension_run_id")]
        [STJS.JsonPropertyName("extension_run_id")]
        public string ExtensionRunId { get; set; }
    }
}
