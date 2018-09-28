namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class OrderListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return orders for the given customer.
        /// </summary>
        [FormProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Only return orders with the given IDs.
        /// </summary>
        [FormProperty("ids")]
        public string[] Ids { get; set; }

        /// <summary>
        /// Only return orders that have the given status. One of created, paid, fulfilled, or refunded.
        /// </summary>
        [FormProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Only return orders that match the given status_transitions. One of canceled, fulfilled, paid or returned.
        /// </summary>
        [FormProperty("status_transitions")]
        public OrderStatusTransitionsOptions StatusTransitions { get; set; }

        /// <summary>
        /// Only return orders with the given upstream order IDs.
        /// </summary>
        [FormProperty("upstream_ids")]
        public string[] UpstreamIds { get; set; }
    }
}
