// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;

    public class EventDestinationWebhookEndpoint : StripeEntity<EventDestinationWebhookEndpoint>
    {
        /// <summary>
        /// The signing secret of the webhook endpoint, only includable on creation.
        /// </summary>
        [JsonProperty("signing_secret")]
        public string SigningSecret { get; set; }

        /// <summary>
        /// The URL of the webhook endpoint, includable.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
