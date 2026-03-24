// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OnboardingLinkCreateOptions : BaseOptions
    {
        /// <summary>
        /// Specific fields needed to generate the desired link type.
        /// </summary>
        [JsonProperty("link_options")]
        [STJS.JsonPropertyName("link_options")]
        public OnboardingLinkLinkOptionsOptions LinkOptions { get; set; }

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
    }
}
