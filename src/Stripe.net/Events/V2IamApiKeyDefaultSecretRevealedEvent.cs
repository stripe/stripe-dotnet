// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when the default API Key's secret is revealed.
    /// </summary>
    public class V2IamApiKeyDefaultSecretRevealedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.iam.api_key.default_secret_revealed event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2IamApiKeyDefaultSecretRevealedEventData Data { get; set; }
    }
}
