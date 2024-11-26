// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReviewSession : StripeEntity<ReviewSession>
    {
        /// <summary>
        /// The browser used in this browser session (e.g., <c>Chrome</c>).
        /// </summary>
        [JsonProperty("browser")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("browser")]
#endif
        public string Browser { get; set; }

        /// <summary>
        /// Information about the device used for the browser session (e.g., <c>Samsung
        /// SM-G930T</c>).
        /// </summary>
        [JsonProperty("device")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("device")]
#endif
        public string Device { get; set; }

        /// <summary>
        /// The platform for the browser session (e.g., <c>Macintosh</c>).
        /// </summary>
        [JsonProperty("platform")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("platform")]
#endif
        public string Platform { get; set; }

        /// <summary>
        /// The version for the browser session (e.g., <c>61.0.3163.100</c>).
        /// </summary>
        [JsonProperty("version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("version")]
#endif
        public string Version { get; set; }
    }
}
