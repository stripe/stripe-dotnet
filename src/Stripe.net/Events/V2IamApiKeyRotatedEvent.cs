// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when an API Key is rotated.
    /// </summary>
    public class V2IamApiKeyRotatedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.iam.api_key.rotated event.
        /// </summary>
        [JsonProperty("data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")]
#endif

        public V2IamApiKeyRotatedEventData Data { get; set; }
    }
}
