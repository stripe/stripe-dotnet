// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class EventDestinationWebhookEndpoint : StripeEntity<EventDestinationWebhookEndpoint>
    {
        /// <summary>
        /// The signing secret of the webhook endpoint, only includable on creation.
        /// </summary>
        [JsonProperty("signing_secret")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("signing_secret")]
#endif
        public string SigningSecret { get; set; }

        /// <summary>
        /// The URL of the webhook endpoint, includable.
        /// </summary>
        [JsonProperty("url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("url")]
#endif
        public string Url { get; set; }
    }
}
