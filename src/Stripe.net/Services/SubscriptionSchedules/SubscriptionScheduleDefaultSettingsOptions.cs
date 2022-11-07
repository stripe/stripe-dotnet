// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionScheduleDefaultSettingsOptions : INestedOptions
    {
        /// <summary>
        /// A non-negative decimal between 0 and 100, with at most two decimal places. This
        /// represents the percentage of the subscription invoice subtotal that will be transferred
        /// to the application owner's Stripe account. The request must be made by a platform
        /// account on a connected account in order to set an application fee percentage. For more
        /// information, see the application fees <a
        /// href="https://stripe.com/docs/connect/subscriptions#collecting-fees-on-subscriptions">documentation</a>.
        /// </summary>
        [JsonProperty("application_fee_percent")]
        public decimal? ApplicationFeePercent { get; set; }

        /// <summary>
        /// Default settings for automatic tax computation.
        /// </summary>
        [JsonProperty("automatic_tax")]
        public SubscriptionScheduleDefaultSettingsAutomaticTaxOptions AutomaticTax { get; set; }

        /// <summary>
        /// Can be set to <c>phase_start</c> to set the anchor to the start of the phase or
        /// <c>automatic</c> to automatically change it if needed. Cannot be set to
        /// <c>phase_start</c> if this phase specifies a trial. For more information, see the
        /// billing cycle <a
        /// href="https://stripe.com/docs/billing/subscriptions/billing-cycle">documentation</a>.
        /// One of: <c>automatic</c>, or <c>phase_start</c>.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        public string BillingCycleAnchor { get; set; }

        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the subscription advanced to a
        /// new billing period. Pass an empty string to remove previously-defined thresholds.
        /// </summary>
        [JsonProperty("billing_thresholds")]
        public SubscriptionScheduleDefaultSettingsBillingThresholdsOptions BillingThresholds { get; set; }

        /// <summary>
        /// Either <c>charge_automatically</c>, or <c>send_invoice</c>. When charging automatically,
        /// Stripe will attempt to pay the underlying subscription at the end of each billing cycle
        /// using the default source attached to the customer. When sending an invoice, Stripe will
        /// email your customer an invoice with payment instructions and mark the subscription as
        /// <c>active</c>. Defaults to <c>charge_automatically</c> on creation.
        /// One of: <c>charge_automatically</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        /// <summary>
        /// ID of the default payment method for the subscription schedule. It must belong to the
        /// customer associated with the subscription schedule. If not set, invoices will use the
        /// default payment method in the customer's invoice settings.
        /// </summary>
        [JsonProperty("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }

        /// <summary>
        /// Subscription description, meant to be displayable to the customer. Use this field to
        /// optionally store an explanation of the subscription.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// All invoices will be billed using the specified settings.
        /// </summary>
        [JsonProperty("invoice_settings")]
        public SubscriptionScheduleDefaultSettingsInvoiceSettingsOptions InvoiceSettings { get; set; }

        /// <summary>
        /// The account on behalf of which to charge, for each of the associated subscription's
        /// invoices.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// The data with which to automatically create a Transfer for each of the associated
        /// subscription's invoices.
        /// </summary>
        [JsonProperty("transfer_data")]
        public SubscriptionScheduleDefaultSettingsTransferDataOptions TransferData { get; set; }
    }
}
