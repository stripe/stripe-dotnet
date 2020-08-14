namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class OrderCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A coupon code that represents a discount to be applied to this order. Must be one-time
        /// duration and in same currency as the order. An order can have multiple coupons.
        /// </summary>
        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The ID of an existing customer to use for this order. If provided, the customer email
        /// and shipping address will be used to create the order. Subsequently, the customer will
        /// also be charged to pay the order. If <c>email</c> or <c>shipping</c> are also provided,
        /// they will override the values retrieved from the customer object.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The email address of the customer placing the order.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// List of items constituting the order. An order can have up to 25 items.
        /// </summary>
        [JsonProperty("items")]
        public List<OrderItemOptions> Items { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Shipping address for the order. Required if any of the SKUs are for products that have
        /// <c>shippable</c> set to true.
        /// </summary>
        [JsonProperty("shipping")]
        public ShippingOptions Shipping { get; set; }
    }
}
