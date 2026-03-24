// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ApiKeyListOptions : V2.ListOptions
    {
        /// <summary>
        /// Whether to include expired API keys in the response.
        /// </summary>
        [JsonProperty("include_expired")]
        [STJS.JsonPropertyName("include_expired")]
        public bool? IncludeExpired { get; set; }
    }
}
