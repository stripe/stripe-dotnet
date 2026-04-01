// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2IamApiKeyUpdatedEventData : StripeEntity<V2IamApiKeyUpdatedEventData>
    {
        /// <summary>
        /// ID of the updated key.
        /// </summary>
        [JsonProperty("api_key")]
        [STJS.JsonPropertyName("api_key")]
        public string ApiKey { get; set; }
    }
}
