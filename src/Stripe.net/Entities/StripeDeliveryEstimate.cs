using Newtonsoft.Json;

namespace Stripe
{
    public class StripeDeliveryEstimate : StripeEntity
    {
        /// <summary>
        /// If type is "exact", date will be the expected delivery date in the format YYYY-MM-DD.
        /// </summary>
        [JsonProperty("date")]
        public string Date { get; set; }

        /// <summary>
        /// If type is "range", earliest will be be the earliest delivery date in the format YYYY-MM-DD.
        /// </summary>
        [JsonProperty("earliest")]
        public string Earliest { get; set; }

        /// <summary>
        /// If type is "range", latest will be the latest delivery date in the format YYYY-MM-DD
        /// </summary>
        [JsonProperty("latest")]
        public string Latest { get; set; }

        /// <summary>
        /// The type of estimate. Must be either "range" or "exact".
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
