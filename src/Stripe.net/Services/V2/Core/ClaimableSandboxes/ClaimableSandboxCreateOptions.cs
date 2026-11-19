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
        /// The distribution channel used to pre-install your Stripe App on the claimable sandbox.
        /// Use <c>testing</c> to install your app's external test version or <c>public</c> to
        /// install its published version. This field defaults to <c>public</c> if omitted.
        /// One of: <c>public</c>, or <c>testing</c>.
        /// </summary>
        [JsonProperty("channel")]
        [STJS.JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// If true, returns a key that can be used with <a
        /// href="https://docs.stripe.com/mcp">Stripe's MCP server</a>.
        /// </summary>
        [JsonProperty("enable_mcp_access")]
        [STJS.JsonPropertyName("enable_mcp_access")]
        public bool? EnableMcpAccess { get; set; }

        /// <summary>
        /// Details about the onboarding link.
        /// </summary>
        [JsonProperty("onboarding_link_details")]
        [STJS.JsonPropertyName("onboarding_link_details")]
        public ClaimableSandboxCreateOnboardingLinkDetailsOptions OnboardingLinkDetails { get; set; }

        /// <summary>
        /// Values that are prefilled when a user claims the sandbox. When a user claims the
        /// sandbox, they will be able to update these values.
        /// </summary>
        [JsonProperty("prefill")]
        [STJS.JsonPropertyName("prefill")]
        public ClaimableSandboxCreatePrefillOptions Prefill { get; set; }
    }
}
