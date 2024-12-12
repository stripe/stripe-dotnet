// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// The collection method of the invoice to retrieve. Either <c>charge_automatically</c> or
        /// <c>send_invoice</c>.
        /// One of: <c>charge_automatically</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collection_method")]
#endif
        public string CollectionMethod { get; set; }

        /// <summary>
        /// Only return invoices for the customer specified by this customer ID.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        [JsonProperty("due_date")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("due_date")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, DateRangeOptions> DueDate { get; set; }

        /// <summary>
        /// The status of the invoice, one of <c>draft</c>, <c>open</c>, <c>paid</c>,
        /// <c>uncollectible</c>, or <c>void</c>. <a
        /// href="https://stripe.com/docs/billing/invoices/workflow#workflow-overview">Learn
        /// more</a>.
        /// One of: <c>draft</c>, <c>open</c>, <c>paid</c>, <c>uncollectible</c>, or <c>void</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Only return invoices for the subscription specified by this subscription ID.
        /// </summary>
        [JsonProperty("subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription")]
#endif
        public string Subscription { get; set; }
    }
}
