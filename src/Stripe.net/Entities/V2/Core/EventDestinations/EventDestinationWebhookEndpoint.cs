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
        /// The secret used to verify Stripe signatures on delivered events. Returned only in the
        /// create response when explicitly included; public API clients cannot retrieve it later.
        /// </summary>
        [JsonProperty("signing_secret")]
        [STJS.JsonPropertyName("signing_secret")]
        public string SigningSecret { get; set; }

        /// <summary>
        /// The URL where Stripe sends matching events. Live mode requires HTTPS; sandbox mode also
        /// supports HTTP. Returned only when explicitly included.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
