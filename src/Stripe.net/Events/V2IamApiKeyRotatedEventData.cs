// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    public class V2IamApiKeyRotatedEventData : StripeEntity<V2IamApiKeyRotatedEventData>
    {
        /// <summary>
        /// ID of the new key that was created due to rotation.
        /// </summary>
        [JsonProperty("new_api_key")]
        [STJS.JsonPropertyName("new_api_key")]
        public string NewApiKey { get; set; }
    }
}
