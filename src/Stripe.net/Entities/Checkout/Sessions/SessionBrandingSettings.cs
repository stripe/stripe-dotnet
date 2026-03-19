// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionBrandingSettings : StripeEntity<SessionBrandingSettings>
    {
        /// <summary>
        /// A hex color value starting with <c>#</c> representing the background color for the
        /// Checkout Session.
        /// </summary>
        [JsonProperty("background_color")]
        [STJS.JsonPropertyName("background_color")]
        public string BackgroundColor { get; set; }

        /// <summary>
        /// The border style for the Checkout Session. Must be one of <c>rounded</c>,
        /// <c>rectangular</c>, or <c>pill</c>.
        /// One of: <c>pill</c>, <c>rectangular</c>, or <c>rounded</c>.
        /// </summary>
        [JsonProperty("border_style")]
        [STJS.JsonPropertyName("border_style")]
        public string BorderStyle { get; set; }

        /// <summary>
        /// A hex color value starting with <c>#</c> representing the button color for the Checkout
        /// Session.
        /// </summary>
        [JsonProperty("button_color")]
        [STJS.JsonPropertyName("button_color")]
        public string ButtonColor { get; set; }

        /// <summary>
        /// The display name shown on the Checkout Session.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The font family for the Checkout Session. Must be one of the <a
        /// href="https://docs.stripe.com/payments/checkout/customization/appearance?payment-ui=stripe-hosted#font-compatibility">supported
        /// font families</a>.
        /// </summary>
        [JsonProperty("font_family")]
        [STJS.JsonPropertyName("font_family")]
        public string FontFamily { get; set; }

        /// <summary>
        /// The icon for the Checkout Session. You cannot set both <c>logo</c> and <c>icon</c>.
        /// </summary>
        [JsonProperty("icon")]
        [STJS.JsonPropertyName("icon")]
        public SessionBrandingSettingsIcon Icon { get; set; }

        /// <summary>
        /// The logo for the Checkout Session. You cannot set both <c>logo</c> and <c>icon</c>.
        /// </summary>
        [JsonProperty("logo")]
        [STJS.JsonPropertyName("logo")]
        public SessionBrandingSettingsLogo Logo { get; set; }
    }
}
