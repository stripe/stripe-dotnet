// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ClaimableSandboxCreateOptions : BaseOptions
    {
        /// <summary>
        /// If true, returns a key that can be used with <a
        /// href="https://docs.stripe.com/mcp">Stripe's MCP server</a>.
        /// </summary>
        [JsonProperty("enable_mcp_access")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enable_mcp_access")]
#endif
        public bool? EnableMcpAccess { get; set; }

        /// <summary>
        /// Values that are prefilled when a user claims the sandbox.
        /// </summary>
        [JsonProperty("prefill")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("prefill")]
#endif
        public ClaimableSandboxCreatePrefillOptions Prefill { get; set; }
    }
}
