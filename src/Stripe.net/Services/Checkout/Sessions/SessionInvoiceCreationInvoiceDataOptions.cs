// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionInvoiceCreationInvoiceDataOptions : INestedOptions, IHasMetadata, IHasSetTracking
    {
        private List<string> accountTaxIds;
        private List<SessionInvoiceCreationInvoiceDataCustomFieldOptions> customFields;
        private SessionInvoiceCreationInvoiceDataRenderingOptionsOptions renderingOptions;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// The account tax IDs associated with the invoice.
        /// </summary>
        [JsonProperty("account_tax_ids")]
        [STJS.JsonPropertyName("account_tax_ids")]
        public List<string> AccountTaxIds
        {
            get => this.accountTaxIds;
            set
            {
                this.accountTaxIds = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Default custom fields to be displayed on invoices for this customer.
        /// </summary>
        [JsonProperty("custom_fields")]
        [STJS.JsonPropertyName("custom_fields")]
        public List<SessionInvoiceCreationInvoiceDataCustomFieldOptions> CustomFields
        {
            get => this.customFields;
            set
            {
                this.customFields = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Default footer to be displayed on invoices for this customer.
        /// </summary>
        [JsonProperty("footer")]
        [STJS.JsonPropertyName("footer")]
        public string Footer { get; set; }

        /// <summary>
        /// The connected account that issues the invoice. The invoice is presented with the
        /// branding and support information of the specified account.
        /// </summary>
        [JsonProperty("issuer")]
        [STJS.JsonPropertyName("issuer")]
        public SessionInvoiceCreationInvoiceDataIssuerOptions Issuer { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Default options for invoice PDF rendering for this customer.
        /// </summary>
        [JsonProperty("rendering_options")]
        [STJS.JsonPropertyName("rendering_options")]
        public SessionInvoiceCreationInvoiceDataRenderingOptionsOptions RenderingOptions
        {
            get => this.renderingOptions;
            set
            {
                this.renderingOptions = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
