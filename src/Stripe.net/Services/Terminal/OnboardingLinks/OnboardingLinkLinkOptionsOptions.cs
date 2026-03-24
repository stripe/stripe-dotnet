// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OnboardingLinkLinkOptionsOptions : INestedOptions
    {
        /// <summary>
        /// The options associated with the Apple Terms and Conditions link type.
        /// </summary>
        [JsonProperty("apple_terms_and_conditions")]
        [STJS.JsonPropertyName("apple_terms_and_conditions")]
        public OnboardingLinkLinkOptionsAppleTermsAndConditionsOptions AppleTermsAndConditions { get; set; }
    }
}
