namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionScheduleDefaultSettings : StripeEntity<SubscriptionScheduleDefaultSettings>
    {
        /// <summary>
        /// Possible values are <c>phase_start</c> or <c>automatic</c>. If <c>phase_start</c> then
        /// billing cycle anchor of the subscription is set to the start of the phase when entering
        /// the phase. If <c>automatic</c> then the billing cycle anchor is automatically modified
        /// as needed when entering the phase. For more information, see the billing cycle <a
        /// href="https://stripe.com/docs/billing/subscriptions/billing-cycle">documentation</a>.
        /// One of: <c>automatic</c>, or <c>phase_start</c>.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        public string BillingCycleAnchor { get; set; }

        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the subscription advanced to a
        /// new billing period.
        /// </summary>
        [JsonProperty("billing_thresholds")]
        public SubscriptionScheduleDefaultSettingsBillingThresholds BillingThresholds { get; set; }

        /// <summary>
        /// Either <c>charge_automatically</c>, or <c>send_invoice</c>. When charging automatically,
        /// Stripe will attempt to pay the underlying subscription at the end of each billing cycle
        /// using the default source attached to the customer. When sending an invoice, Stripe will
        /// email your customer an invoice with payment instructions.
        /// One of: <c>charge_automatically</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        #region Expandable DefaultPaymentMethod

        /// <summary>
        /// (ID of the PaymentMethod)
        /// ID of the default payment method for the subscription schedule. If not set, invoices
        /// will use the default payment method in the customer's invoice settings.
        /// </summary>
        [JsonIgnore]
        public string DefaultPaymentMethodId
        {
            get => this.InternalDefaultPaymentMethod?.Id;
            set => this.InternalDefaultPaymentMethod = SetExpandableFieldId(value, this.InternalDefaultPaymentMethod);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the default payment method for the subscription schedule. If not set, invoices
        /// will use the default payment method in the customer's invoice settings.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
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
        /// The subscription schedule's default invoice settings.
        /// </summary>
        [JsonProperty("invoice_settings")]
        public SubscriptionScheduleDefaultSettingsInvoiceSettings InvoiceSettings { get; set; }

        /// <summary>
        /// The account (if any) the subscription's payments will be attributed to for tax
        /// reporting, and where funds from each payment will be transferred to for each of the
        /// subscription's invoices.
        /// </summary>
        [JsonProperty("transfer_data")]
        public SubscriptionScheduleDefaultSettingsTransferData TransferData { get; set; }
    }
}
