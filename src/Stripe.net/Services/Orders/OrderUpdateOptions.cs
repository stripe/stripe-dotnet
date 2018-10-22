namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class OrderUpdateOptions : BaseOptions
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
        /// Tracking information once the order has been fulfilled.
        /// </summary>
        [JsonProperty("shipping")]
        public OrderUpdateShippingOptions Shipping { get; set; }

        /// <summary>
        /// Current order status. One of created, paid, canceled, fulfilled, or returned.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
