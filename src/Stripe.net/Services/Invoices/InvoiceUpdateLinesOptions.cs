// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class InvoiceUpdateLinesOptions : BaseOptions
    {
        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>. For
        /// <c>type=recurring</c> line items, the incoming metadata specified on the request is
        /// directly used to set this value, in contrast to <c>type=invoiceitem</c> line items,
        /// where any existing metadata on the invoice line is merged with the incoming data.
        /// </summary>
        [JsonProperty("invoice_metadata")]
        public Dictionary<string, string> InvoiceMetadata { get; set; }

        /// <summary>
        /// The line items to update.
        /// </summary>
        [JsonProperty("lines")]
        public List<InvoiceLineOptions> Lines { get; set; }
    }
}
