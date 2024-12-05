// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionInvoiceSettings : StripeEntity<SubscriptionInvoiceSettings>
    {
        #region Expandable AccountTaxIds

        /// <summary>
        /// (IDs of the AccountTaxIds)
        /// The account tax IDs associated with the subscription. Will be set on invoices generated
        /// by the subscription.
        /// </summary>
        [JsonIgnore]
        public List<string> AccountTaxIdIds
        {
            get => this.InternalAccountTaxIds?.Select((x) => x.Id).ToList();
            set => this.InternalAccountTaxIds = SetExpandableArrayIds<TaxId>(value);
        }

        /// <summary>
        /// (Expanded)
        /// The account tax IDs associated with the subscription. Will be set on invoices generated
        /// by the subscription.
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

        [JsonProperty("issuer")]
        public SubscriptionInvoiceSettingsIssuer Issuer { get; set; }
    }
}
