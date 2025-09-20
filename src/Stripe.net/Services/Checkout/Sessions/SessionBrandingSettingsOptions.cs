// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionBrandingSettingsOptions : INestedOptions
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
        /// The border style for the Checkout Session.
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
        /// A string to override the business name shown on the Checkout Session.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

        /// <summary>
        /// The font family for the Checkout Session corresponding to one of the <a
        /// href="https://docs.stripe.com/payments/checkout/customization/appearance?payment-ui=stripe-hosted#font-compatibility">supported
        /// font families</a>.
        /// One of: <c>be_vietnam_pro</c>, <c>bitter</c>, <c>chakra_petch</c>, <c>default</c>,
        /// <c>hahmlet</c>, <c>inconsolata</c>, <c>inter</c>, <c>lato</c>, <c>lora</c>,
        /// <c>m_plus_1_code</c>, <c>montserrat</c>, <c>noto_sans</c>, <c>noto_sans_jp</c>,
        /// <c>noto_serif</c>, <c>nunito</c>, <c>open_sans</c>, <c>pridi</c>, <c>pt_sans</c>,
        /// <c>pt_serif</c>, <c>raleway</c>, <c>roboto</c>, <c>roboto_slab</c>,
        /// <c>source_sans_pro</c>, <c>titillium_web</c>, <c>ubuntu_mono</c>, or
        /// <c>zen_maru_gothic</c>.
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
        public SessionBrandingSettingsIconOptions Icon { get; set; }

        /// <summary>
        /// The logo for the Checkout Session. You cannot set both <c>logo</c> and <c>icon</c>.
        /// </summary>
        [JsonProperty("logo")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("logo")]
#endif
        public SessionBrandingSettingsLogoOptions Logo { get; set; }
    }
}
