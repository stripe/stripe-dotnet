// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SessionInvoiceCreationInvoiceData : StripeEntity<SessionInvoiceCreationInvoiceData>, IHasMetadata
    {
        #region Expandable AccountTaxIds

        /// <summary>
        /// (IDs of the AccountTaxIds)
        /// The account tax IDs associated with the invoice.
        /// </summary>
        [JsonIgnore]
        public List<string> AccountTaxIdIds
        {
            get => this.InternalAccountTaxIds?.Select((x) => x.Id).ToList();
            set => this.InternalAccountTaxIds = SetExpandableArrayIds<TaxId>(value);
        }

        /// <summary>
        /// (Expanded)
        /// The account tax IDs associated with the invoice.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public List<TaxId> AccountTaxIds
        {
            get => this.InternalAccountTaxIds?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalAccountTaxIds = SetExpandableArrayObjects(value);
        }

        [JsonProperty("account_tax_ids", ItemConverterType = typeof(ExpandableFieldConverter<TaxId>))]
        internal List<ExpandableField<TaxId>> InternalAccountTaxIds { get; set; }
        #endregion

        /// <summary>
        /// Custom fields displayed on the invoice.
        /// </summary>
        [JsonProperty("custom_fields")]
        public List<SessionInvoiceCreationInvoiceDataCustomField> CustomFields { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Footer displayed on the invoice.
        /// </summary>
        [JsonProperty("footer")]
        public string Footer { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Options for invoice PDF rendering.
        /// </summary>
        [JsonProperty("rendering_options")]
        public SessionInvoiceCreationInvoiceDataRenderingOptions RenderingOptions { get; set; }
    }
}
