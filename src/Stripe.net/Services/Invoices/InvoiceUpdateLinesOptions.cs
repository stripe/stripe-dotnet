// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceUpdateLinesOptions : BaseOptions
    {
        private Dictionary<string, string> invoiceMetadata;

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>. For <a
        /// href="https://docs.stripe.com/api/invoices/line_item#invoice_line_item_object-type">type=subscription</a>
        /// line items, the incoming metadata specified on the request is directly used to set this
        /// value, in contrast to <a
        /// href="api/invoices/line_item#invoice_line_item_object-type">type=invoiceitem</a> line
        /// items, where any existing metadata on the invoice line is merged with the incoming data.
        /// </summary>
        [JsonProperty("invoice_metadata", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("invoice_metadata")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string> InvoiceMetadata
        {
            get => this.invoiceMetadata;
            set
            {
                this.invoiceMetadata = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The line items to update.
        /// </summary>
        [JsonProperty("lines")]
        [STJS.JsonPropertyName("lines")]
        public List<InvoiceLineOptions> Lines { get; set; }
    }
}
