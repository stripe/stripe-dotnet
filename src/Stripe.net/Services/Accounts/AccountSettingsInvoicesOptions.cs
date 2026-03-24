// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSettingsInvoicesOptions : INestedOptions, IHasSetTracking
    {
        private List<string> defaultAccountTaxIds;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// The list of default Account Tax IDs to automatically include on invoices. Account Tax
        /// IDs get added when an invoice is finalized.
        /// </summary>
        [JsonProperty("default_account_tax_ids")]
        [STJS.JsonPropertyName("default_account_tax_ids")]
        public List<string> DefaultAccountTaxIds
        {
            get => this.defaultAccountTaxIds;
            set
            {
                this.defaultAccountTaxIds = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Whether to save the payment method after a payment is completed for a one-time invoice
        /// or a subscription invoice when the customer already has a default payment method on the
        /// hosted invoice page.
        /// One of: <c>always</c>, <c>never</c>, or <c>offer</c>.
        /// </summary>
        [JsonProperty("hosted_payment_method_save")]
        [STJS.JsonPropertyName("hosted_payment_method_save")]
        public string HostedPaymentMethodSave { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
