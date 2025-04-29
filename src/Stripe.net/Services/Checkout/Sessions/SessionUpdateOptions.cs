// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Information about the customer collected within the Checkout Session. Can only be set
        /// when updating <c>embedded</c> or <c>custom</c> sessions.
        /// </summary>
        [JsonProperty("collected_information")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collected_information")]
#endif
        public SessionCollectedInformationOptions CollectedInformation { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The shipping rate options to apply to this Session. Up to a maximum of 5.
        /// </summary>
        [JsonProperty("shipping_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_options")]
#endif
        public List<SessionShippingOptionOptions> ShippingOptions { get; set; }
    }
}
