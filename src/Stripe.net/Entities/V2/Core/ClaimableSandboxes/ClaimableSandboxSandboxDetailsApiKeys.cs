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
        /// Used to communicate with <a href="https://docs.stripe.com/mcp">Stripe's MCP server</a>.
        /// This allows LLM agents to securely operate on a Stripe account.
        /// </summary>
        [JsonProperty("mcp")]
        [STJS.JsonPropertyName("mcp")]
        public string Mcp { get; set; }

        /// <summary>
        /// Publicly accessible in a web or mobile app client-side code.
        /// </summary>
        [JsonProperty("publishable")]
        [STJS.JsonPropertyName("publishable")]
        public string Publishable { get; set; }

        /// <summary>
        /// Should be stored securely in server-side code (such as an environment variable).
        /// </summary>
        [JsonProperty("secret")]
        [STJS.JsonPropertyName("secret")]
        public string Secret { get; set; }
    }
}
