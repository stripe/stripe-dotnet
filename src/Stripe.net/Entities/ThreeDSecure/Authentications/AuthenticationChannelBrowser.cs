// File generated from our OpenAPI spec
namespace Stripe.ThreeDSecure
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthenticationChannelBrowser : StripeEntity<AuthenticationChannelBrowser>
    {
        /// <summary>
        /// The HTTP accept headers from the cardholder's browser.
        /// </summary>
        [JsonProperty("accept_header")]
        [STJS.JsonPropertyName("accept_header")]
        public string AcceptHeader { get; set; }

        /// <summary>
        /// The color depth of the cardholder’s screen.
        /// </summary>
        [JsonProperty("color_depth")]
        [STJS.JsonPropertyName("color_depth")]
        public long ColorDepth { get; set; }

        /// <summary>
        /// The IP address of the browser.
        /// </summary>
        [JsonProperty("ip_address")]
        [STJS.JsonPropertyName("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// The cardholder browser’s ability to execute Java.
        /// </summary>
        [JsonProperty("java_enabled")]
        [STJS.JsonPropertyName("java_enabled")]
        public bool JavaEnabled { get; set; }

        /// <summary>
        /// The cardholder browser’s ability to execute JavaScript.
        /// </summary>
        [JsonProperty("javascript_enabled")]
        [STJS.JsonPropertyName("javascript_enabled")]
        public bool JavascriptEnabled { get; set; }

        /// <summary>
        /// An IETF BCP 47 language tag representing the browser language.
        /// </summary>
        [JsonProperty("language")]
        [STJS.JsonPropertyName("language")]
        public string Language { get; set; }

        /// <summary>
        /// The total height of the cardholder’s screen in pixels.
        /// </summary>
        [JsonProperty("screen_height")]
        [STJS.JsonPropertyName("screen_height")]
        public long ScreenHeight { get; set; }

        /// <summary>
        /// The total width of the cardholder’s screen in pixels.
        /// </summary>
        [JsonProperty("screen_width")]
        [STJS.JsonPropertyName("screen_width")]
        public long ScreenWidth { get; set; }

        /// <summary>
        /// The time difference between UTC time and the local time of the cardholder’s browser, in
        /// minutes.
        /// </summary>
        [JsonProperty("timezone_offset")]
        [STJS.JsonPropertyName("timezone_offset")]
        public long TimezoneOffset { get; set; }

        /// <summary>
        /// The browser user agent.
        /// </summary>
        [JsonProperty("user_agent")]
        [STJS.JsonPropertyName("user_agent")]
        public string UserAgent { get; set; }
    }
}
