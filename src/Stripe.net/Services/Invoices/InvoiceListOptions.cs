namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class InvoiceListOptions : ListOptions
    {
        /// <summary>
        /// The billing mode of the invoice to retrieve. One of <see cref="Billing" />.
        /// </summary>
        [JsonProperty("billing")]
        public Billing? Billing { get; set; }

        [JsonProperty("created")]
        public DateTime? Created { get; set; }

        /// <summary>
        /// A filter on the list based on the object created field.
        /// </summary>
        [JsonProperty("created")]
        public DateRangeOptions CreatedRange { get; set; }

        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("due_date")]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// A filter on the list based on the object due_date field.
        /// </summary>
        [JsonProperty("due_date")]
        public DateRangeOptions DueDateRange { get; set; }

        /// <summary>
        /// A filter on the list based on the object paid field.
        /// </summary>
        [JsonProperty("paid")]
        public bool? Paid { get; set; }

        [JsonProperty("subscription")]
        public string SubscriptionId { get; set; }
    }
}
