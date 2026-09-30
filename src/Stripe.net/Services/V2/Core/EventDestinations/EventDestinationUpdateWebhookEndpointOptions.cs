// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class EventDestinationUpdateWebhookEndpointOptions : INestedOptions
    {
        /// <summary>
        /// The URL where Stripe sends matching events. Live mode requires HTTPS; sandbox mode also
        /// supports HTTP.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
