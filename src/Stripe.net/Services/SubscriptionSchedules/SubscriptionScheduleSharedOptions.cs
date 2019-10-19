namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public abstract class SubscriptionScheduleSharedOptions : BaseOptions, IHasMetadata
    {
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
        /// ID of the default source for the subscription schedule.
        /// </summary>
        [JsonProperty("default_source")]
        public string DefaultSource { get; set; }

        /// <summary>
        /// Behavior of the subscription schedule and underlying subscription when it ends. Possible
        /// values are <c>cancel</c>, <c>none</c>, <c>release</c> and <c>renew</c>.
        /// </summary>
        [JsonProperty("end_behavior")]
        public string EndBehavior { get; set; }

        /// <summary>
        /// Define the default settings applied to invoices created by this subscription schedule.
        /// </summary>
        [JsonProperty("invoice_settings")]
        public SubscriptionScheduleInvoiceSettingsOptions InvoiceSettings { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a subscription schedule object.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// List representing phases of the subscription schedule. Each phase can be customized to
        /// have different durations, plans, and coupons. If there are multiple phases, the
        /// <c>end_date</c> of one phase will always equal the <c>start_date</c> of the
        /// next phase.
        /// </summary>
        [JsonProperty("phases")]
        public List<SubscriptionSchedulePhaseOptions> Phases { get; set; }
    }
}
