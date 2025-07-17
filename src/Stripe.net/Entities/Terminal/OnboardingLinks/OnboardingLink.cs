// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Returns redirect links used for onboarding onto Tap to Pay on iPhone.
    /// </summary>
    public class OnboardingLink : StripeEntity<OnboardingLink>, IHasObject
    {
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Link type options associated with the current onboarding link object.
        /// </summary>
        [JsonProperty("link_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("link_options")]
#endif
        public OnboardingLinkLinkOptions LinkOptions { get; set; }

        /// <summary>
        /// The type of link being generated.
        /// </summary>
        [JsonProperty("link_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("link_type")]
#endif
        public string LinkType { get; set; }

        /// <summary>
        /// Stripe account ID to generate the link for.
        /// </summary>
        [JsonProperty("on_behalf_of")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("on_behalf_of")]
#endif
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// The link passed back to the user for their onboarding.
        /// </summary>
        [JsonProperty("redirect_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("redirect_url")]
#endif
        public string RedirectUrl { get; set; }
    }
}
