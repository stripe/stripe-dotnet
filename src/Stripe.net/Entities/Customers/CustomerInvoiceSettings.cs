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
        public string DefaultPaymentMethodId { get; set; }

        [JsonIgnore]
        public PaymentMethod DefaultPaymentMethod { get; set; }

        [JsonProperty("default_payment_method")]
        internal object InternalDefaultPaymentMethod
        {
            get
            {
                return this.DefaultPaymentMethod ?? (object)this.DefaultPaymentMethodId;
            }

            set
            {
                StringOrObject<PaymentMethod>.Map(value, s => this.DefaultPaymentMethodId = s, o => this.DefaultPaymentMethod = o);
            }
        }

        #endregion

        /// <summary>
        /// Default footer to be displayed on invoices for this customer.
        /// </summary>
        [JsonProperty("footer")]
        public string Footer { get; set; }
    }
}
