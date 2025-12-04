// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2IamApiKeyRotatedEventData : StripeEntity<V2IamApiKeyRotatedEventData>
    {
        /// <summary>
        /// ID of the new key that was created due to rotation.
        /// </summary>
        [JsonProperty("new_api_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("new_api_key")]
#endif
        public string NewApiKey { get; set; }
    }
}
