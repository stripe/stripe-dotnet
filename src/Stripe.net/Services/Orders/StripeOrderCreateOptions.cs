using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeOrderCreateOptions : StripeOrderUpsertOptionsBase
    {
        /// <summary>
        /// Gets or sets 3-letter ISO code representing the currency in which the order was made.
        /// REQUIRED
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets The ID of an existing customer to use for this order. If provided, the customer email and shipping address will be used to create the order. Subsequently, the customer will also be charged to pay the order. If email or shipping are also provided, they will override the values retrieved from the customer object.
        /// </summary>
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the email address of the customer placing the order.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets a list of items constituting the order.
        /// </summary>
        [JsonProperty("items")]
        public List<StripeOrderItem> StripeOrderItems { get; set; }

        /// <summary>
        /// Gets or sets the Shipping address for the order. Required if any of the SKUs are for products that have shippable set to true.
        /// </summary>
        [JsonProperty("shipping")]
        public StripeShippingOptions Shipping { get; set; }
    }
}
