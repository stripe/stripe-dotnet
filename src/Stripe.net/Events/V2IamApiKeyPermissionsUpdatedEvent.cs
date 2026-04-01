// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when an API Key's permissions are updated.
    /// </summary>
    public class V2IamApiKeyPermissionsUpdatedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.iam.api_key.permissions_updated event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2IamApiKeyPermissionsUpdatedEventData Data { get; set; }
    }
}
