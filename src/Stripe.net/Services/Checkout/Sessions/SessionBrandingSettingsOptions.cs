// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionBrandingSettingsOptions : INestedOptions, IHasSetTracking
    {
        private string backgroundColor;
        private string borderStyle;
        private string buttonColor;
        private string fontFamily;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// A hex color value starting with <c>#</c> representing the background color for the
        /// Checkout Session.
        /// </summary>
        [JsonProperty("background_color", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("background_color")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string BackgroundColor
        {
            get => this.backgroundColor;
            set
            {
                this.backgroundColor = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The border style for the Checkout Session.
        /// One of: <c>pill</c>, <c>rectangular</c>, or <c>rounded</c>.
        /// </summary>
        [JsonProperty("border_style", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("border_style")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string BorderStyle
        {
            get => this.borderStyle;
            set
            {
                this.borderStyle = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// A hex color value starting with <c>#</c> representing the button color for the Checkout
        /// Session.
        /// </summary>
        [JsonProperty("button_color", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("button_color")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string ButtonColor
        {
            get => this.buttonColor;
            set
            {
                this.buttonColor = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// A string to override the business name shown on the Checkout Session. This only shows at
        /// the top of the Checkout page, and your business name still appears in terms, receipts,
        /// and other places.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
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
        [JsonProperty("font_family", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("font_family")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string FontFamily
        {
            get => this.fontFamily;
            set
            {
                this.fontFamily = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The icon for the Checkout Session. For best results, use a square image.
        /// </summary>
        [JsonProperty("icon")]
        [STJS.JsonPropertyName("icon")]
        public SessionBrandingSettingsIconOptions Icon { get; set; }

        /// <summary>
        /// The logo for the Checkout Session.
        /// </summary>
        [JsonProperty("logo")]
        [STJS.JsonPropertyName("logo")]
        public SessionBrandingSettingsLogoOptions Logo { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
