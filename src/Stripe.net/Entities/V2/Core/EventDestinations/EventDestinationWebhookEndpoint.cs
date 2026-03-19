// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class EventDestinationWebhookEndpoint : StripeEntity<EventDestinationWebhookEndpoint>
    {
        /// <summary>
        /// The signing secret of the webhook endpoint, only includable on creation.
        /// </summary>
        [JsonProperty("signing_secret")]
        [STJS.JsonPropertyName("signing_secret")]
        public string SigningSecret { get; set; }

        /// <summary>
        /// The URL of the webhook endpoint, includable.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
