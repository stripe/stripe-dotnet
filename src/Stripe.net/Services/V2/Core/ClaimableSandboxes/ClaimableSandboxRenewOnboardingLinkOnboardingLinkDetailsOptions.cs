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
        /// The URL the user will be redirected to if the onboarding link is expired or invalid. The
        /// URL specified should attempt to generate a new onboarding link, and re-direct the user
        /// to this new onboarding link so that they can proceed with the onboarding flow.
        /// </summary>
        [JsonProperty("refresh_url")]
        [STJS.JsonPropertyName("refresh_url")]
        public string RefreshUrl { get; set; }
    }
}
