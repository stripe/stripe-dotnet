// File generated from our OpenAPI spec
namespace Stripe.ThreeDSecure
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AuthenticationChannelBrowserOptions : INestedOptions
    {
        /// <summary>
        /// The HTTP accept headers from the cardholder's browser. Collected server-side.
        /// </summary>
        [JsonProperty("accept_header")]
        [STJS.JsonPropertyName("accept_header")]
        public string AcceptHeader { get; set; }

        /// <summary>
        /// The color depth of the cardholder’s screen.
        ///
        /// Returned from the <c>screen.colorDepth</c> property.
        /// </summary>
        [JsonProperty("color_depth")]
        [STJS.JsonPropertyName("color_depth")]
        public long? ColorDepth { get; set; }

        /// <summary>
        /// Unique and immutable identifier linked to a device that is consistent across 3DS
        /// transactions for the specific user device. For example: hardware device ID or a
        /// platform-calculated device fingerprint.
        /// </summary>
        [JsonProperty("device_id")]
        [STJS.JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// The IP address of the browser. Included in the HTTP request to your server before you
        /// create the 3DS Authentication.
        ///
        /// Collected server-side.
        /// </summary>
        [JsonProperty("ip_address")]
        [STJS.JsonPropertyName("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// The cardholder browser’s ability to execute Java. Returned from the
        /// navigator.javaEnabled property.
        /// </summary>
        [JsonProperty("java_enabled")]
        [STJS.JsonPropertyName("java_enabled")]
        public bool? JavaEnabled { get; set; }

        /// <summary>
        /// The cardholder browser’s ability to execute JavaScript.
        /// </summary>
        [JsonProperty("javascript_enabled")]
        [STJS.JsonPropertyName("javascript_enabled")]
        public bool? JavascriptEnabled { get; set; }

        /// <summary>
        /// An IETF BCP 47 language tag representing the browser language. Typically returned from
        /// the <c>navigator.language</c> property, but might also be returned from
        /// <c>navigator.languages</c> or <c>navigator.browserLanguage</c>.
        ///
        /// In some cases, this value might be an array. To cast it to a string or null value, you
        /// can use the <c>getBrowserLanguage()</c> <a
        /// href="https://stripe.com/payments/3d-secure/standalone-3d-secure#pass-client-side-collected-channel-information">example
        /// function</a>.
        /// </summary>
        [JsonProperty("language")]
        [STJS.JsonPropertyName("language")]
        public string Language { get; set; }

        /// <summary>
        /// The total height of the cardholder’s screen in pixels.
        ///
        /// Returned from the <c>screen.height</c> property.
        /// </summary>
        [JsonProperty("screen_height")]
        [STJS.JsonPropertyName("screen_height")]
        public long? ScreenHeight { get; set; }

        /// <summary>
        /// The total width of the cardholder’s screen in pixels.
        ///
        /// Returned from the <c>screen.width</c> property.
        /// </summary>
        [JsonProperty("screen_width")]
        [STJS.JsonPropertyName("screen_width")]
        public long? ScreenWidth { get; set; }

        /// <summary>
        /// The time difference between UTC time and the local time of the cardholder’s browser, in
        /// minutes.
        ///
        /// Returned by <c>new Date().getTimezoneOffset()</c>.
        /// </summary>
        [JsonProperty("timezone_offset")]
        [STJS.JsonPropertyName("timezone_offset")]
        public long? TimezoneOffset { get; set; }

        /// <summary>
        /// The browser user agent. You can retrieve this value on the client side using the
        /// <c>navigator.userAgent</c> property, or in the HTTP request to your server before you
        /// create the 3DS Authentication.
        /// </summary>
        [JsonProperty("user_agent")]
        [STJS.JsonPropertyName("user_agent")]
        public string UserAgent { get; set; }
    }
}
