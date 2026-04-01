// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when an API Key is updated.
    /// </summary>
    public class V2IamApiKeyUpdatedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.iam.api_key.updated event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2IamApiKeyUpdatedEventData Data { get; set; }
    }
}
