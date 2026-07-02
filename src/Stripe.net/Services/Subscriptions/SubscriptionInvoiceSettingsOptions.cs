// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionInvoiceSettingsOptions : INestedOptions, IHasSetTracking
    {
        private List<string> accountTaxIds;
        private List<SubscriptionInvoiceSettingsCustomFieldOptions> customFields;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// The account tax IDs associated with the subscription. Will be set on invoices generated
        /// by the subscription.
        /// </summary>
        [JsonProperty("account_tax_ids", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("account_tax_ids")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
        /// A list of up to 4 custom fields to be displayed on the invoice.
        /// </summary>
        [JsonProperty("custom_fields", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("custom_fields")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<SubscriptionInvoiceSettingsCustomFieldOptions> CustomFields
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
        /// Footer to be displayed on the invoice.
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
        public SubscriptionInvoiceSettingsIssuerOptions Issuer { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
