// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ClaimableSandboxSandboxDetailsApiKeys : StripeEntity<ClaimableSandboxSandboxDetailsApiKeys>
    {
        /// <summary>
        /// Used to communicate with <a href="https://docs.stripe.com/mcp">Stripe's MCP server</a>.
        /// This allows LLM agents to securely operate on a Stripe account.
        /// </summary>
        [JsonProperty("mcp")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mcp")]
#endif
        public string Mcp { get; set; }

        /// <summary>
        /// Publicly accessible in a web or mobile app client-side code.
        /// </summary>
        [JsonProperty("publishable")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("publishable")]
#endif
        public string Publishable { get; set; }

        /// <summary>
        /// Should be stored securely in server-side code (such as an environment variable).
        /// </summary>
        [JsonProperty("secret")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("secret")]
#endif
        public string Secret { get; set; }
    }
}
