namespace Stripe
{
    using Newtonsoft.Json;

    public class OrderUpdateShippingOptions : INestedOptions
    {
        /// <summary>
        /// The name of the carrier like USPS, UPS, or FedEx. ShippingTrackingNumber must also be set with this property.
        /// </summary>
        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// The tracking number provided by the carrier. ShippingCarrier must also be set with this property.
        /// </summary>
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }
    }
}
