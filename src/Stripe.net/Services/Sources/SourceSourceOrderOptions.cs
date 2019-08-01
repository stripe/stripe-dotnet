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
        /// The shipping address for the order. Present if the order is for
        /// goods to be shipped.
        /// </summary>
        [JsonProperty("shipping")]
        public ChargeShippingOptions Shipping { get; set; }
    }
}
