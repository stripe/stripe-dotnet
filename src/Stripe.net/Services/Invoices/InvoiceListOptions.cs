﻿namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceListOptions : ListOptions
    {
        /// <summary>
        /// The billing mode of the invoice to retrieve. One of <see cref="StripeBilling" />.
        /// </summary>
        [JsonProperty("billing")]
        public StripeBilling? Billing { get; set; }

        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("date")]
        public DateFilter Date { get; set; }

        /// <summary>
        /// A filter on the list based on the object due_date field.
        /// </summary>
        [JsonProperty("due_date")]
        public DateFilter DueDate { get; set; }

        /// <summary>
        /// A filter on the list based on the object paid field.
        /// </summary>
        [JsonProperty("paid")]
        public bool? Paid { get; set; }

        [JsonProperty("subscription")]
        public string SubscriptionId { get; set; }
    }
}
