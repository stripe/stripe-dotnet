// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentLinkInvoiceCreationInvoiceDataOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// The account tax IDs associated with the invoice.
        /// </summary>
        [JsonProperty("account_tax_ids")]
        public List<string> AccountTaxIds { get; set; }

        /// <summary>
        /// Default custom fields to be displayed on invoices for this customer.
        /// </summary>
        [JsonProperty("custom_fields")]
        public List<PaymentLinkInvoiceCreationInvoiceDataCustomFieldOptions> CustomFields { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Default footer to be displayed on invoices for this customer.
        /// </summary>
        [JsonProperty("footer")]
        public string Footer { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Default options for invoice PDF rendering for this customer.
        /// </summary>
        [JsonProperty("rendering_options")]
        public PaymentLinkInvoiceCreationInvoiceDataRenderingOptionsOptions RenderingOptions { get; set; }
    }
}
