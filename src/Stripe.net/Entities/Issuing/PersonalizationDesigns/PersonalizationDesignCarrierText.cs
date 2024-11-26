// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PersonalizationDesignCarrierText : StripeEntity<PersonalizationDesignCarrierText>
    {
        /// <summary>
        /// The footer body text of the carrier letter.
        /// </summary>
        [JsonProperty("footer_body")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("footer_body")]
#endif
        public string FooterBody { get; set; }

        /// <summary>
        /// The footer title text of the carrier letter.
        /// </summary>
        [JsonProperty("footer_title")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("footer_title")]
#endif
        public string FooterTitle { get; set; }

        /// <summary>
        /// The header body text of the carrier letter.
        /// </summary>
        [JsonProperty("header_body")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("header_body")]
#endif
        public string HeaderBody { get; set; }

        /// <summary>
        /// The header title text of the carrier letter.
        /// </summary>
        [JsonProperty("header_title")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("header_title")]
#endif
        public string HeaderTitle { get; set; }
    }
}
