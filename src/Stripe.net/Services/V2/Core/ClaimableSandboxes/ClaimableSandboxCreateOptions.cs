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
        /// The app channel that will be used when pre-installing your app on the claimable sandbox.
        /// This field defaults to <c>public</c> if omitted.
        /// One of: <c>public</c>, or <c>testing</c>.
        /// </summary>
        [JsonProperty("app_channel")]
        [STJS.JsonPropertyName("app_channel")]
        public string AppChannel { get; set; }

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
