// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceItemListOptions : ListOptions
    {
        /// <summary>
        /// Only return invoice items that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// The identifier of the customer whose invoice items to return. If none is provided,
        /// returns all invoice items.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The identifier of the account representing the customer whose invoice items to return.
        /// If none is provided, returns all invoice items.
        /// </summary>
        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        /// <summary>
        /// Only return invoice items belonging to this invoice. If none is provided, all invoice
        /// items will be returned. If specifying an invoice, no customer identifier is needed.
        /// </summary>
        [JsonProperty("invoice")]
        [STJS.JsonPropertyName("invoice")]
        public string Invoice { get; set; }

        /// <summary>
        /// Set to <c>true</c> to only show pending invoice items, which are not yet attached to any
        /// invoices. Set to <c>false</c> to only show invoice items already attached to invoices.
        /// If unspecified, no filter is applied.
        /// </summary>
        [JsonProperty("pending")]
        [STJS.JsonPropertyName("pending")]
        public bool? Pending { get; set; }
    }
}
