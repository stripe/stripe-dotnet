using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.net;

namespace Stripe
{
    public class StripeOrderListOptions : StripeListOptionsWithCreated
    {
        /// <summary>
        /// Only return orders for the given customer.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Only return orders with the given IDs.
        /// </summary>
        [JsonProperty("ids")]
        public string[] Ids { get; set; }

        /// <summary>
        /// Only return orders that have the given status. One of created, paid, fulfilled, or refunded.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        // todo: add status transitions when needed. perhaps just classes like StripeListOptionsWithCreated?

        /// <summary>
        /// Only return orders with the given upstream order IDs.
        /// </summary>
        [JsonProperty("upstream_ids")]
        public string[] UpstreamIds { get; set; }
    }
}
