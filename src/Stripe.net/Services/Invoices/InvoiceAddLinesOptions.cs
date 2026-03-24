// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceAddLinesOptions : BaseOptions
    {
        private Dictionary<string, string> invoiceMetadata;

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("invoice_metadata")]
        [STJS.JsonPropertyName("invoice_metadata")]
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
        /// The line items to add.
        /// </summary>
        [JsonProperty("lines")]
        [STJS.JsonPropertyName("lines")]
        public List<InvoiceLineOptions> Lines { get; set; }
    }
}
