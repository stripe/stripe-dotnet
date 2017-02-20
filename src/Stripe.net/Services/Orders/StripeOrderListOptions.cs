using Newtonsoft.Json;
using Stripe.Services.Orders;

namespace Stripe
{
    public class StripeOrderListOptions : StripeListSelectedOptionsBase
    {
        /// <summary>
        /// Gets or sets a filter on the list based on the object created field. The value can be a string with an integer Unix timestamp, or it can be a dictionary with the following options:
        /// </summary>
        [JsonProperty("created")]
        public StripeDateFilter CreatedFilter { get; set; }

        /// <summary>
        /// Gets or sets the customer id.
        /// Only return orders for the given customer
        /// </summary>
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// Only return orders that have the given status. One of created, paid, fulfilled, or refunded.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the status transition filters.
        /// Filter orders based on when they were paid, fulfilled, canceled, or returned
        /// </summary>
        [JsonProperty("status_transitions")]
        public StripeStatusTransitionsFilter StatusTransitions { get; set; }

        /// <summary>
        /// Gets or sets the upstream ids.
        /// Only return orders with the given upstream order IDs
        /// </summary>
        [JsonProperty("upstream_ids")]
        public string[] UpstreamIds { get; set; }
    }
}
