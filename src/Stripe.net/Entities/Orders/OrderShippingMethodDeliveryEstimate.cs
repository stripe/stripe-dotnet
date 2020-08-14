namespace Stripe
{
    using Newtonsoft.Json;

    public class OrderShippingMethodDeliveryEstimate : StripeEntity<OrderShippingMethodDeliveryEstimate>
    {
        /// <summary>
        /// If <c>type</c> is <c>"exact"</c>, <c>date</c> will be the expected delivery date in the
        /// format YYYY-MM-DD.
        /// </summary>
        [JsonProperty("date")]
        public string Date { get; set; }

        /// <summary>
        /// If <c>type</c> is <c>"range"</c>, <c>earliest</c> will be be the earliest delivery date
        /// in the format YYYY-MM-DD.
        /// </summary>
        [JsonProperty("earliest")]
        public string Earliest { get; set; }

        /// <summary>
        /// If <c>type</c> is <c>"range"</c>, <c>latest</c> will be the latest delivery date in the
        /// format YYYY-MM-DD.
        /// </summary>
        [JsonProperty("latest")]
        public string Latest { get; set; }

        /// <summary>
        /// The type of estimate. Must be either <c>"range"</c> or <c>"exact"</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
