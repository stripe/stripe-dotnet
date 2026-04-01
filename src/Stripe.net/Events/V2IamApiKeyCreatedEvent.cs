// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when an API Key is created.
    /// </summary>
    public class V2IamApiKeyCreatedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.iam.api_key.created event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2IamApiKeyCreatedEventData Data { get; set; }
    }
}
