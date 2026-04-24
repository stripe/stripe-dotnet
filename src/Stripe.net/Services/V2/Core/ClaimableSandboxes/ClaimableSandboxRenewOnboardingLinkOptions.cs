// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ClaimableSandboxRenewOnboardingLinkOptions : BaseOptions
    {
        /// <summary>
        /// Details about the onboarding link. If omitted, the existing onboarding link details will
        /// be reused.
        /// </summary>
        [JsonProperty("onboarding_link_details")]
        [STJS.JsonPropertyName("onboarding_link_details")]
        public ClaimableSandboxRenewOnboardingLinkOnboardingLinkDetailsOptions OnboardingLinkDetails { get; set; }
    }
}
