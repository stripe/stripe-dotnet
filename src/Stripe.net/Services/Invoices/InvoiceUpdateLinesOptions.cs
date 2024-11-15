// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceUpdateLinesOptions : BaseOptions
    {
        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>. For <a
        /// href="https://stripe.com/docs/api/invoices/line_item#invoice_line_item_object-type">type=subscription</a>
        /// line items, the incoming metadata specified on the request is directly used to set this
        /// value, in contrast to <a
        /// href="api/invoices/line_item#invoice_line_item_object-type">type=invoiceitem</a> line
        /// items, where any existing metadata on the invoice line is merged with the incoming data.
        /// </summary>
        [JsonProperty("invoice_metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_metadata")]
#endif

        public Dictionary<string, string> InvoiceMetadata { get; set; }

        /// <summary>
        /// The line items to update.
        /// </summary>
        [JsonProperty("lines")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lines")]
#endif

        public List<InvoiceLineOptions> Lines { get; set; }
    }
}
