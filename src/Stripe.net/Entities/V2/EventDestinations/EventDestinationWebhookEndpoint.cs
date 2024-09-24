// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;

    public class EventDestinationWebhookEndpoint : StripeEntity<EventDestinationWebhookEndpoint>
    {
        /// <summary>
        /// The URL of the webhook endpoint.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
