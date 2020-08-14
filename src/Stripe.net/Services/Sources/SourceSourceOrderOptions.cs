namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SourceSourceOrderOptions : INestedOptions
    {
        /// <summary>
        /// List of items constituting the order.
        /// </summary>
        [JsonProperty("items")]
        public List<SourceSourceOrderItemOptions> Items { get; set; }

        /// <summary>
        /// Shipping address for the order. Required if any of the SKUs are for products that have
        /// <c>shippable</c> set to true.
        /// </summary>
        [JsonProperty("shipping")]
        public ChargeShippingOptions Shipping { get; set; }
    }
}
