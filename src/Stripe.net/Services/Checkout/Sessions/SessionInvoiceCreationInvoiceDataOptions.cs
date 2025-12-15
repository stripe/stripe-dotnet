// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionInvoiceCreationInvoiceDataOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// The account tax IDs associated with the invoice.
        /// </summary>
        [JsonProperty("account_tax_ids")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_tax_ids")]
#endif
        public List<string> AccountTaxIds { get; set; }

        /// <summary>
        /// Default custom fields to be displayed on invoices for this customer.
        /// </summary>
        [JsonProperty("custom_fields")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_fields")]
#endif
        public List<SessionInvoiceCreationInvoiceDataCustomFieldOptions> CustomFields { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// Default footer to be displayed on invoices for this customer.
        /// </summary>
        [JsonProperty("footer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("footer")]
#endif
        public string Footer { get; set; }

        /// <summary>
        /// The connected account that issues the invoice. The invoice is presented with the
        /// branding and support information of the specified account.
        /// </summary>
        [JsonProperty("issuer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuer")]
#endif
        public SessionInvoiceCreationInvoiceDataIssuerOptions Issuer { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Default options for invoice PDF rendering for this customer.
        /// </summary>
        [JsonProperty("rendering_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rendering_options")]
#endif
        public SessionInvoiceCreationInvoiceDataRenderingOptionsOptions RenderingOptions { get; set; }
    }
}
