using Newtonsoft.Json;

namespace Stripe
{
    public class StripeShipping : StripeEntity
    {
        /// <summary>
        /// Shipping address.
        /// </summary>
        [JsonProperty("address")]
        public StripeAddress Address { get; set; }

        /// <summary>
        /// The delivery service that shipped a physical product, such as Fedex, UPS, USPS, etc.
        /// </summary>
        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// Recipient name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Recipient phone (including extension).
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The tracking number for a physical product, obtained from the delivery service. If multiple tracking numbers were generated for this purchase, please separate them with commas.
        /// </summary>
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }
    }
}