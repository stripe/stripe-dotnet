namespace Stripe
{
    using Newtonsoft.Json;

    public class ReviewSession : StripeEntity<ReviewSession>
    {
        /// <summary>
        /// The browser used in this browser session (e.g., <c>Chrome</c>).
        /// </summary>
        [JsonProperty("browser")]
        public string Browser { get; set; }

        /// <summary>
        /// Information about the device used for the browser session (e.g., <c>Samsung
        /// SM-G930T</c>).
        /// </summary>
        [JsonProperty("device")]
        public string Device { get; set; }

        /// <summary>
        /// The platform for the browser session (e.g., <c>Macintosh</c>).
        /// </summary>
        [JsonProperty("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// The version for the browser session (e.g., <c>61.0.3163.100</c>).
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
