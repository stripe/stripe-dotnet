using Newtonsoft.Json;

namespace Stripe
{
    public class StripeDeliveryEstimate : StripeEntity
    {
        /// <summary>
        /// Gets or sets the expected delivery date.
        /// v2017-01-27: If type is "exact", date will be the expected delivery date in the format YYYY-MM-DD
        /// </summary>
        [JsonProperty("date")]
        public string Date { get; set; }

        /// <summary>
        /// Gets or sets the earliest delivery date.
        /// v2017-01-27: If type is "range", earliest will be be the earliest delivery date in the format YYYY-MM-DD
        /// </summary>
        [JsonProperty("earliest")]
        public string Earliest { get; set; }

        /// <summary>
        /// Gets or sets the latest delivery date.
        /// v2017-01-27: If type is "range", latest will be the latest delivery date in the format YYYY-MM-DD
        /// </summary>
        [JsonProperty("latest")]
        public string Latest { get; set; }

        /// <summary>
        /// v2017-01-27: Gets or sets the type of estimate. Must be either "range" or "exact"
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
