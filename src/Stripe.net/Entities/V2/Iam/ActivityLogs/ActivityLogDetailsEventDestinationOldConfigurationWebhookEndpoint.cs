// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsEventDestinationOldConfigurationWebhookEndpoint : StripeEntity<ActivityLogDetailsEventDestinationOldConfigurationWebhookEndpoint>
    {
        /// <summary>
        /// URL configured for the webhook endpoint.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
