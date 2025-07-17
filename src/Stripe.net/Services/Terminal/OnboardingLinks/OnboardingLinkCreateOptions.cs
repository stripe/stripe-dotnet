// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OnboardingLinkCreateOptions : BaseOptions
    {
        /// <summary>
        /// Specific fields needed to generate the desired link type.
        /// </summary>
        [JsonProperty("link_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("link_options")]
#endif
        public OnboardingLinkLinkOptionsOptions LinkOptions { get; set; }

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
    }
}
