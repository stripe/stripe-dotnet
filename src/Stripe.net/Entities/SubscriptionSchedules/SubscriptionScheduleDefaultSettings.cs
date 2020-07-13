namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionScheduleDefaultSettings : StripeEntity<SubscriptionScheduleDefaultSettings>
    {
        /// <summary>
        /// Can be set to <c>phase_start</c> to set the anchor to the start of the phase
        /// or <c>automatic</c> to automatically change it if needed. Cannot be set to
        /// <c>phase_start</c> if this phase specifies a trial.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        public string BillingCycleAnchor { get; set; }

        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the subscription advanced to a
        /// new billing period.
        /// </summary>
        [JsonProperty("billing_thresholds")]
        public SubscriptionBillingThresholds BillingThresholds { get; set; }

        /// <summary>
        /// Either <c>charge_automatically</c>, or <c>send_invoice</c>. When charging
        /// automatically, Stripe will attempt to pay this subscription at the
        /// end of the cycle using the default source attached to the customer.
        /// When sending an invoice, Stripe will email your customer an invoice
        /// with payment instructions.
        /// </summary>
        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        #region Expandable DefaultPaymentMethod

        /// <summary>
        /// ID of the default payment method for the subscription schedule.
        /// </summary>
        [JsonIgnore]
        public string DefaultPaymentMethodId
        {
            get => this.InternalDefaultPaymentMethod?.Id;
            set => this.InternalDefaultPaymentMethod = SetExpandableFieldId(value, this.InternalDefaultPaymentMethod);
        }

        [JsonIgnore]
        public PaymentMethod DefaultPaymentMethod
        {
            get => this.InternalDefaultPaymentMethod?.ExpandedObject;
            set => this.InternalDefaultPaymentMethod = SetExpandableFieldObject(value, this.InternalDefaultPaymentMethod);
        }

        [JsonProperty("default_payment_method")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentMethod>))]
        internal ExpandableField<PaymentMethod> InternalDefaultPaymentMethod { get; set; }
        #endregion

        /// <summary>
        /// The schedule's default invoice settings.
        /// </summary>
        [JsonProperty("invoice_settings")]
        public SubscriptionScheduleInvoiceSettings InvoiceSettings { get; set; }

        /// <summary>
        /// The account (if any) the subscription's payments will be
        /// attributed to for tax reporting, and where funds from each
        /// payment will be transferred to for each of the subscription's
        /// invoices.
        /// </summary>
        [JsonProperty("transfer_data")]
        public SubscriptionTransferData TransferData { get; set; }
    }
}
