// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Returns redirect links used for onboarding onto Tap to Pay on iPhone.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OnboardingLink : StripeEntity<OnboardingLink>, IHasObject
    {
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Link type options associated with the current onboarding link object.
        /// </summary>
        [JsonProperty("link_options")]
        [STJS.JsonPropertyName("link_options")]
        public OnboardingLinkLinkOptions LinkOptions { get; set; }

        /// <summary>
        /// The type of link being generated.
        /// </summary>
        [JsonProperty("link_type")]
        [STJS.JsonPropertyName("link_type")]
        public string LinkType { get; set; }

        /// <summary>
        /// Stripe account ID to generate the link for.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        [STJS.JsonPropertyName("on_behalf_of")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// The link passed back to the user for their onboarding.
        /// </summary>
        [JsonProperty("redirect_url")]
        [STJS.JsonPropertyName("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
