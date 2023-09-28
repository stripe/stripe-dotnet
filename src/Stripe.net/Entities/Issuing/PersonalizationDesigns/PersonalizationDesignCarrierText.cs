// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class PersonalizationDesignCarrierText : StripeEntity<PersonalizationDesignCarrierText>
    {
        /// <summary>
        /// The footer body text of the carrier letter.
        /// </summary>
        [JsonProperty("footer_body")]
        public string FooterBody { get; set; }

        /// <summary>
        /// The footer title text of the carrier letter.
        /// </summary>
        [JsonProperty("footer_title")]
        public string FooterTitle { get; set; }

        /// <summary>
        /// The header body text of the carrier letter.
        /// </summary>
        [JsonProperty("header_body")]
        public string HeaderBody { get; set; }

        /// <summary>
        /// The header title text of the carrier letter.
        /// </summary>
        [JsonProperty("header_title")]
        public string HeaderTitle { get; set; }
    }
}
