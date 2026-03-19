// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PersonalizationDesignCarrierText : StripeEntity<PersonalizationDesignCarrierText>
    {
        /// <summary>
        /// The footer body text of the carrier letter.
        /// </summary>
        [JsonProperty("footer_body")]
        [STJS.JsonPropertyName("footer_body")]
        public string FooterBody { get; set; }

        /// <summary>
        /// The footer title text of the carrier letter.
        /// </summary>
        [JsonProperty("footer_title")]
        [STJS.JsonPropertyName("footer_title")]
        public string FooterTitle { get; set; }

        /// <summary>
        /// The header body text of the carrier letter.
        /// </summary>
        [JsonProperty("header_body")]
        [STJS.JsonPropertyName("header_body")]
        public string HeaderBody { get; set; }

        /// <summary>
        /// The header title text of the carrier letter.
        /// </summary>
        [JsonProperty("header_title")]
        [STJS.JsonPropertyName("header_title")]
        public string HeaderTitle { get; set; }
    }
}
