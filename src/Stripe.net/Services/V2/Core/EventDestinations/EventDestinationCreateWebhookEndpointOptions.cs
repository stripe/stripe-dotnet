// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;

    public class EventDestinationCreateWebhookEndpointOptions : INestedOptions
    {
        /// <summary>
        /// The URL of the webhook endpoint.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
