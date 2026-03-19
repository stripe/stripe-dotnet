// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ChargeShippingOptions : INestedOptions
    {
        /// <summary>
        /// Shipping address.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The delivery service that shipped a physical product, such as Fedex, UPS, USPS, etc.
        /// </summary>
        [JsonProperty("carrier")]
        [STJS.JsonPropertyName("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// Recipient name.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Recipient phone (including extension).
        /// </summary>
        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The tracking number for a physical product, obtained from the delivery service. If
        /// multiple tracking numbers were generated for this purchase, please separate them with
        /// commas.
        /// </summary>
        [JsonProperty("tracking_number")]
        [STJS.JsonPropertyName("tracking_number")]
        public string TrackingNumber { get; set; }
    }
}
