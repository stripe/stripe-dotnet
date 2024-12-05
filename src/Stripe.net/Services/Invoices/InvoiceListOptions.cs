// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// The collection method of the invoice to retrieve. Either <c>charge_automatically</c> or
        /// <c>send_invoice</c>.
        /// One of: <c>charge_automatically</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        /// <summary>
        /// Only return invoices for the customer specified by this customer ID.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("due_date")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> DueDate { get; set; }

        /// <summary>
        /// The status of the invoice, one of <c>draft</c>, <c>open</c>, <c>paid</c>,
        /// <c>uncollectible</c>, or <c>void</c>. <a
        /// href="https://stripe.com/docs/billing/invoices/workflow#workflow-overview">Learn
        /// more</a>.
        /// One of: <c>draft</c>, <c>open</c>, <c>paid</c>, <c>uncollectible</c>, or <c>void</c>.
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
