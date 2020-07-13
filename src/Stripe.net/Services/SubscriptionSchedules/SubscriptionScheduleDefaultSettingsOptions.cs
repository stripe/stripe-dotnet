namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionScheduleDefaultSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Can be set to <c>phase_start</c> to set the anchor to the
        /// start of the phase or <c>automatic</c> to automatically
        /// change it if needed. Cannot be set to <c>phase_start</c> if
        /// this phase specifies a trial.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        public string BillingCycleAnchor { get; set; }

        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the subscription advanced to a
        /// new billing period. Pass an empty string to remove previously-defined thresholds.
        /// </summary>
        [JsonProperty("billing_thresholds")]
        public SubscriptionBillingThresholdsOptions BillingThresholds { get; set; }

        /// <summary>
        /// Either <c>charge_automatically</c>, or <c>send_invoice</c>. When
        /// charging automatically, Stripe will attempt to pay the underlying
        /// subscription at the end of each billing cycle using the default
        /// source attached to the customer. When sending an invoice, Stripe
        /// will email your customer an invoice with payment instructions.
        /// Defaults to <c>charge_automatically</c> on creation.
        /// </summary>
        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        /// <summary>
        /// ID of the default payment method for the subscription schedule.
        /// </summary>
        [JsonProperty("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }

        /// <summary>
        /// Define the default settings applied to invoices created by this subscription schedule.
        /// </summary>
        [JsonProperty("invoice_settings")]
        public SubscriptionScheduleInvoiceSettingsOptions InvoiceSettings { get; set; }

        /// <summary>
        /// The account (if any) the subscription's payments will be attributed
        /// to for tax reporting, and where funds from each payment will be
        /// transferred to for each of the subscription's invoices.
        /// </summary>
        [JsonProperty("transfer_data")]
        public SubscriptionTransferDataOptions TransferData { get; set; }
    }
}
