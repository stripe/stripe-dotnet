// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceItemListOptions : ListOptions
    {
        /// <summary>
        /// Only return invoice items that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// The identifier of the customer whose invoice items to return. If none is provided, all
        /// invoice items will be returned.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// Only return invoice items belonging to this invoice. If none is provided, all invoice
        /// items will be returned. If specifying an invoice, no customer identifier is needed.
        /// </summary>
        [JsonProperty("invoice")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice")]
#endif
        public string Invoice { get; set; }

        /// <summary>
        /// Set to <c>true</c> to only show pending invoice items, which are not yet attached to any
        /// invoices. Set to <c>false</c> to only show invoice items already attached to invoices.
        /// If unspecified, no filter is applied.
        /// </summary>
        [JsonProperty("pending")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pending")]
#endif
        public bool? Pending { get; set; }
    }
}
