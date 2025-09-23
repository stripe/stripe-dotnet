// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionBrandingSettings : StripeEntity<SessionBrandingSettings>
    {
        /// <summary>
        /// A hex color value starting with <c>#</c> representing the background color for the
        /// Checkout Session.
        /// </summary>
        [JsonProperty("background_color")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("background_color")]
#endif
        public string BackgroundColor { get; set; }

        /// <summary>
        /// The border style for the Checkout Session. Must be one of <c>rounded</c>,
        /// <c>rectangular</c>, or <c>pill</c>.
        /// One of: <c>pill</c>, <c>rectangular</c>, or <c>rounded</c>.
        /// </summary>
        [JsonProperty("border_style")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("border_style")]
#endif
        public string BorderStyle { get; set; }

        /// <summary>
        /// A hex color value starting with <c>#</c> representing the button color for the Checkout
        /// Session.
        /// </summary>
        [JsonProperty("button_color")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("button_color")]
#endif
        public string ButtonColor { get; set; }

        /// <summary>
        /// The display name shown on the Checkout Session.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

        /// <summary>
        /// The font family for the Checkout Session. Must be one of the <a
        /// href="https://docs.stripe.com/payments/checkout/customization/appearance?payment-ui=stripe-hosted#font-compatibility">supported
        /// font families</a>.
        /// </summary>
        [JsonProperty("font_family")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("font_family")]
#endif
        public string FontFamily { get; set; }

        /// <summary>
        /// The icon for the Checkout Session. You cannot set both <c>logo</c> and <c>icon</c>.
        /// </summary>
        [JsonProperty("icon")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("icon")]
#endif
        public SessionBrandingSettingsIcon Icon { get; set; }

        /// <summary>
        /// The logo for the Checkout Session. You cannot set both <c>logo</c> and <c>icon</c>.
        /// </summary>
        [JsonProperty("logo")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("logo")]
#endif
        public SessionBrandingSettingsLogo Logo { get; set; }
    }
}
