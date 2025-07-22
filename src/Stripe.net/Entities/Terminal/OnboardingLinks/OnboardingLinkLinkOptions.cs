// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OnboardingLinkLinkOptions : StripeEntity<OnboardingLinkLinkOptions>
    {
        /// <summary>
        /// The options associated with the Apple Terms and Conditions link type.
        /// </summary>
        [JsonProperty("apple_terms_and_conditions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("apple_terms_and_conditions")]
#endif
        public OnboardingLinkLinkOptionsAppleTermsAndConditions AppleTermsAndConditions { get; set; }
    }
}
