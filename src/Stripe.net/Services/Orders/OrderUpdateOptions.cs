namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class OrderUpdateOptions : BaseOptions, ISupportMetadata
    {
        /// <summary>
        /// A coupon code that represents a discount to be applied to this order. Must be one-time duration and in tbe same currency as the order.
        /// </summary>
        [FormProperty("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to an order object. It can be useful for storing additional information about the order in a structured format.
        /// </summary>
        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The shipping method to select for fulfilling this order. If specified, must be one of the ids of a shipping method in the shipping_methods array. If specified, will overwrite the existing selected shipping method, updating items as necessary.
        /// </summary>
        [FormProperty("selected_shipping_method")]
        public string SelectedShippingMethod { get; set; }

        /// <summary>
        /// The name of the carrier like USPS, UPS, or FedEx. ShippingTrackingNumber must also be set with this property.
        /// </summary>
        [FormProperty("shipping[carrier]")]
        public string ShippingCarrier { get; set; }

        /// <summary>
        /// The tracking number provided by the carrier. ShippingCarrier must also be set with this property.
        /// </summary>
        [FormProperty("shipping[tracking_number]")]
        public string ShippingTrackingNumber { get; set; }

        /// <summary>
        /// Current order status. One of created, paid, canceled, fulfilled, or returned.
        /// </summary>
        [FormProperty("status")]
        public string Status { get; set; }
    }
}
