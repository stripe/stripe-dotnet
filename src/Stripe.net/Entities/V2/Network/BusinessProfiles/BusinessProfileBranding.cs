// File generated from our OpenAPI spec
namespace Stripe.V2.Network
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BusinessProfileBranding : StripeEntity<BusinessProfileBranding>
    {
        /// <summary>
        /// URL of the icon for the business. The image will be square and at least 128px x 128px.
        /// </summary>
        [JsonProperty("icon")]
        [STJS.JsonPropertyName("icon")]
        public BusinessProfileBrandingIcon Icon { get; set; }

        /// <summary>
        /// URL of the logo for the business. The image will be at least 128px x 128px.
        /// </summary>
        [JsonProperty("logo")]
        [STJS.JsonPropertyName("logo")]
        public BusinessProfileBrandingLogo Logo { get; set; }

        /// <summary>
        /// A CSS hex color value representing the primary branding color for this business.
        /// </summary>
        [JsonProperty("primary_color")]
        [STJS.JsonPropertyName("primary_color")]
        public string PrimaryColor { get; set; }

        /// <summary>
        /// A CSS hex color value representing the secondary branding color for this business.
        /// </summary>
        [JsonProperty("secondary_color")]
        [STJS.JsonPropertyName("secondary_color")]
        public string SecondaryColor { get; set; }
    }
}
