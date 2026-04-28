// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2ExtendExtensionRunFailedEventDataError : StripeEntity<V2ExtendExtensionRunFailedEventDataError>
    {
        /// <summary>
        /// URL to the extension run in Workbench for deeper debugging.
        /// </summary>
        [JsonProperty("debug_url")]
        [STJS.JsonPropertyName("debug_url")]
        public string DebugUrl { get; set; }

        /// <summary>
        /// Detailed error message.
        /// </summary>
        [JsonProperty("message")]
        [STJS.JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
