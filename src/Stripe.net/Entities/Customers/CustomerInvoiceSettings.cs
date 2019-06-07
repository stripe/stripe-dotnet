namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CustomerInvoiceSettings : StripeEntity<CustomerInvoiceSettings>
    {
        /// <summary>
        /// Default custom fields to be displayed on invoices for this customer.
        /// </summary>
        [JsonProperty("custom_fields")]
        public List<InvoiceCustomField> CustomFields { get; set; }

        #region Expandable DefaultPaymentMethod

        /// <summary>
        /// ID of the default payment method for the customer.
        /// </summary>
        [JsonIgnore]
        public string DefaultPaymentMethodId => this.InternalDefaultPaymentMethod.Id;

        [JsonIgnore]
        public PaymentMethod DefaultPaymentMethod => this.InternalDefaultPaymentMethod.ExpandedObject;

        [JsonProperty("default_payment_method")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentMethod>))]
        internal ExpandableField<PaymentMethod> InternalDefaultPaymentMethod { get; set; }
        #endregion

        /// <summary>
        /// Default footer to be displayed on invoices for this customer.
        /// </summary>
        [JsonProperty("footer")]
        public string Footer { get; set; }
    }
}
