namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class OrderUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A coupon code that represents a discount to be applied to this order. Must be one-time
        /// duration and in same currency as the order. An order can have multiple coupons.
        /// </summary>
        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The shipping method to select for fulfilling this order. If specified, must be one of
        /// the <c>id</c>s of a shipping method in the <c>shipping_methods</c> array. If specified,
        /// will overwrite the existing selected shipping method, updating <c>items</c> as
        /// necessary.
        /// </summary>
        [JsonProperty("selected_shipping_method")]
        public string SelectedShippingMethod { get; set; }

        /// <summary>
        /// Tracking information once the order has been fulfilled.
        /// </summary>
        [JsonProperty("shipping")]
        public OrderUpdateShippingOptions Shipping { get; set; }

        /// <summary>
        /// Current order status. One of <c>created</c>, <c>paid</c>, <c>canceled</c>,
        /// <c>fulfilled</c>, or <c>returned</c>. More detail in the <a
        /// href="https://stripe.com/docs/orders/guide#understanding-order-statuses">Orders
        /// Guide</a>.
        /// One of: <c>canceled</c>, <c>created</c>, <c>fulfilled</c>, <c>paid</c>, or
        /// <c>returned</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
