﻿namespace Stripe
{
    using Stripe.Infrastructure;

    public class InvoiceListOptions : ListOptions
    {
        /// <summary>
        /// The billing mode of the invoice to retrieve. One of <see cref="Billing" />.
        /// </summary>
        [FormProperty("billing")]
        public Billing? Billing { get; set; }

        [FormProperty("customer")]
        public string CustomerId { get; set; }

        [FormProperty("date")]
        public DateFilter Date { get; set; }

        /// <summary>
        /// A filter on the list based on the object due_date field.
        /// </summary>
        [FormProperty("due_date")]
        public DateFilter DueDate { get; set; }

        /// <summary>
        /// A filter on the list based on the object paid field.
        /// </summary>
        [FormProperty("paid")]
        public bool? Paid { get; set; }

        [FormProperty("subscription")]
        public string SubscriptionId { get; set; }
    }
}
