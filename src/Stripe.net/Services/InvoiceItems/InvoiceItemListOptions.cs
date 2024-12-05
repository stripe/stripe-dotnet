// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceItemListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// The identifier of the customer whose invoice items to return. If none is provided, all
        /// invoice items will be returned.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Only return invoice items belonging to this invoice. If none is provided, all invoice
        /// items will be returned. If specifying an invoice, no customer identifier is needed.
        /// </summary>
        [JsonProperty("invoice")]
        public string Invoice { get; set; }

        /// <summary>
        /// Set to <c>true</c> to only show pending invoice items, which are not yet attached to any
        /// invoices. Set to <c>false</c> to only show invoice items already attached to invoices.
        /// If unspecified, no filter is applied.
        /// </summary>
        [JsonProperty("pending")]
        public bool? Pending { get; set; }
    }
}
