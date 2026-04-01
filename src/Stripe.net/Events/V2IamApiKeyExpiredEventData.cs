// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2IamApiKeyExpiredEventData : StripeEntity<V2IamApiKeyExpiredEventData>
    {
        /// <summary>
        /// ID of the expired key.
        /// </summary>
        [JsonProperty("api_key")]
        [STJS.JsonPropertyName("api_key")]
        public string ApiKey { get; set; }
    }
}
