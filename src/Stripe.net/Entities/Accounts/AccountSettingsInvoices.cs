// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountSettingsInvoices : StripeEntity<AccountSettingsInvoices>
    {
        #region Expandable DefaultAccountTaxIds

        /// <summary>
        /// (IDs of the DefaultAccountTaxIds)
        /// The list of default Account Tax IDs to automatically include on invoices. Account Tax
        /// IDs get added when an invoice is finalized.
        /// </summary>
        [JsonIgnore]
        public List<string> DefaultAccountTaxIdIds
        {
            get => this.InternalDefaultAccountTaxIds?.Select((x) => x.Id).ToList();
            set => this.InternalDefaultAccountTaxIds = SetExpandableArrayIds<TaxId>(value);
        }

        /// <summary>
        /// (Expanded)
        /// The list of default Account Tax IDs to automatically include on invoices. Account Tax
        /// IDs get added when an invoice is finalized.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public List<TaxId> DefaultAccountTaxIds
        {
            get => this.InternalDefaultAccountTaxIds?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalDefaultAccountTaxIds = SetExpandableArrayObjects(value);
        }

        [JsonProperty("default_account_tax_ids", ItemConverterType = typeof(ExpandableFieldConverter<TaxId>))]
        internal List<ExpandableField<TaxId>> InternalDefaultAccountTaxIds { get; set; }
        #endregion
    }
}
