// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ClaimableSandboxRenewOnboardingLinkOnboardingLinkDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The URL the user will be redirected to if the onboarding link is expired or invalid. If
        /// omitted, the existing refresh URL is retained. The URL should generate a new onboarding
        /// link and redirect the user to it.
        /// </summary>
        [JsonProperty("refresh_url")]
        [STJS.JsonPropertyName("refresh_url")]
        public string RefreshUrl { get; set; }

        /// <summary>
        /// The URL offered to the user as a way back to your app after they claim the sandbox. If
        /// omitted, the existing return URL is retained. Set to null to clear it.
        /// </summary>
        [JsonProperty("return_url")]
        [STJS.JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }
    }
}
