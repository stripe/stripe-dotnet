// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ClaimableSandboxSandboxDetailsApiKeys : StripeEntity<ClaimableSandboxSandboxDetailsApiKeys>
    {
        /// <summary>
        /// Object hash for the sandbox's MCP key. Null unless <c>enable_mcp_access: true</c> was
        /// passed in the creation request.
        /// </summary>
        [JsonProperty("mcp")]
        [STJS.JsonPropertyName("mcp")]
        public ClaimableSandboxSandboxDetailsApiKeysMcp Mcp { get; set; }

        /// <summary>
        /// Object hash for the sandbox's publishable key.
        /// </summary>
        [JsonProperty("publishable")]
        [STJS.JsonPropertyName("publishable")]
        public ClaimableSandboxSandboxDetailsApiKeysPublishable Publishable { get; set; }

        /// <summary>
        /// Object hash for the sandbox's secret key.
        /// </summary>
        [JsonProperty("secret")]
        [STJS.JsonPropertyName("secret")]
        public ClaimableSandboxSandboxDetailsApiKeysSecret Secret { get; set; }
    }
}
