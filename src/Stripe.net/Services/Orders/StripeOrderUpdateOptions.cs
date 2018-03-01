using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeOrderUpdateOptions : StripeBaseOptions, ISupportMetadata
    {
        /// <summary>
        /// A coupon code that represents a discount to be applied to this order. Must be one-time duration and in tbe same currency as the order.
        /// </summary>
        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to an order object. It can be useful for storing additional information about the order in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The shipping method to select for fulfilling this order. If specified, must be one of the ids of a shipping method in the shipping_methods array. If specified, will overwrite the existing selected shipping method, updating items as necessary.
        /// </summary>
        [JsonProperty("selected_shipping_method")]
        public string SelectedShippingMethod { get; set; }

        /// <summary>
        /// The name of the carrier like USPS, UPS, or FedEx. ShippingTrackingNumber must also be set with this property.
        /// </summary>
        [JsonProperty("shipping[carrier]")]
        public string ShippingCarrier { get; set; }

        /// <summary>
        /// The tracking number provided by the carrier. ShippingCarrier must also be set with this property.
        /// </summary>
        [JsonProperty("shipping[tracking_number]")]
        public string ShippingTrackingNumber { get; set; }

        /// <summary>
        /// Current order status. One of created, paid, canceled, fulfilled, or returned.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
