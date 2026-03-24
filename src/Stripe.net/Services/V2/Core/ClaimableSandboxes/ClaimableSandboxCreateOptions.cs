// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ClaimableSandboxCreateOptions : BaseOptions
    {
        /// <summary>
        /// If true, returns a key that can be used with <a
        /// href="https://docs.stripe.com/mcp">Stripe's MCP server</a>.
        /// </summary>
        [JsonProperty("enable_mcp_access")]
        [STJS.JsonPropertyName("enable_mcp_access")]
        public bool? EnableMcpAccess { get; set; }

        /// <summary>
        /// Values that are prefilled when a user claims the sandbox. When a user claims the
        /// sandbox, they will be able to update these values.
        /// </summary>
        [JsonProperty("prefill")]
        [STJS.JsonPropertyName("prefill")]
        public ClaimableSandboxCreatePrefillOptions Prefill { get; set; }
    }
}
