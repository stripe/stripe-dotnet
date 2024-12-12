// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class SubscriptionSchedulePhaseInvoiceSettings : StripeEntity<SubscriptionSchedulePhaseInvoiceSettings>
    {
        #region Expandable AccountTaxIds

        /// <summary>
        /// (IDs of the AccountTaxIds)
        /// The account tax IDs associated with this phase of the subscription schedule. Will be set
        /// on invoices generated by this phase of the subscription schedule.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public List<string> AccountTaxIdIds
        {
            get => this.InternalAccountTaxIds?.Select((x) => x.Id).ToList();
            set => this.InternalAccountTaxIds = SetExpandableArrayIds<TaxId>(value);
        }

        /// <summary>
        /// (Expanded)
        /// The account tax IDs associated with this phase of the subscription schedule. Will be set
        /// on invoices generated by this phase of the subscription schedule.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public List<TaxId> AccountTaxIds
        {
            get => this.InternalAccountTaxIds?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalAccountTaxIds = SetExpandableArrayObjects(value);
        }

        [JsonProperty("account_tax_ids", ItemConverterType = typeof(ExpandableFieldConverter<TaxId>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_tax_ids")]
#endif
        internal List<ExpandableField<TaxId>> InternalAccountTaxIds { get; set; }
        #endregion

        /// <summary>
        /// Number of days within which a customer must pay invoices generated by this subscription
        /// schedule. This value will be <c>null</c> for subscription schedules where
        /// <c>billing=charge_automatically</c>.
        /// </summary>
        [JsonProperty("days_until_due")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("days_until_due")]
#endif
        public long? DaysUntilDue { get; set; }

        /// <summary>
        /// The connected account that issues the invoice. The invoice is presented with the
        /// branding and support information of the specified account.
        /// </summary>
        [JsonProperty("issuer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuer")]
#endif
        public SubscriptionSchedulePhaseInvoiceSettingsIssuer Issuer { get; set; }
    }
}
