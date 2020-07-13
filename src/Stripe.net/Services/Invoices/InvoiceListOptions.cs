namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Either <c>charge_automatically</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        /// <summary>
        /// Only return invoices for the customer specified by this customer ID.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// A filter on the list based on the object <c>due_date</c> field. The value can be a
        /// <see cref="DateTime"/> or a <see cref="DateRangeOptions"/>.
        /// </summary>
        [JsonProperty("due_date")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> DueDate { get; set; }

        /// <summary>
        /// Only return invoices with a given status. Must be one of
        /// <c>draft</c>, <c>open</c>, <c>paid</c>, <c>uncollectible</c>, or
        /// <c>void</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Only return invoices for the subscription specified by this subscription ID.
        /// </summary>
        [JsonProperty("subscription")]
        public string Subscription { get; set; }
    }
}
