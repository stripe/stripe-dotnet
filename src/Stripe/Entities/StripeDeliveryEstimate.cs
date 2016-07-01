using Newtonsoft.Json;

namespace Stripe
{
    public class StripeDeliveryEstimate
    {
        /// <summary>
        /// Gets or sets the expected delivery date.
        /// If type is "exact", date will be the expected delivery date in the format YYYY-MM-DD
        /// </summary>
        [JsonProperty("date")]
        public string Date { get; set; }

        /// <summary>
        /// Gets or sets the earliest delivery date.
        /// If type is "range", earliest will be be the earliest delivery date in the format YYYY-MM-DD
        /// </summary>
        [JsonProperty("earliest")]
        public string Earliest { get; set; }

        /// <summary>
        /// Gets or sets the latest delivery date.
        /// If type is "range", latest will be the latest delivery date in the format YYYY-MM-DD
        /// </summary>
        [JsonProperty("latest")]
        public string Latest { get; set; }

        /// <summary>
        /// Gets or sets the type of estimate. Must be either "range" or "exact"
        /// </summary>
        [JsonProperty("Type")]
        public string Type { get; set; }
    }
}