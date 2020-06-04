namespace Stripe
{
    using Newtonsoft.Json;

    public class ReviewSession : StripeEntity<ReviewSession>
    {
        /// <summary>
        /// The browser used in this browser session.
        /// </summary>
        [JsonProperty("browser")]
        public string Browser { get; set; }

        /// <summary>
        /// Information about the device used for the browser session.
        /// </summary>
        [JsonProperty("device")]
        public string Device { get; set; }

        /// <summary>
        /// The platform for the browser session.
        /// </summary>
        [JsonProperty("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// The version for the browser session.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
