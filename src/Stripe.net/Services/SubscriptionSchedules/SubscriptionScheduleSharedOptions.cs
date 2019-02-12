namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public abstract class SubscriptionScheduleSharedOptions : BaseOptions
    {
        /// <summary>
        /// One of <see cref="Billing" />. When charging automatically, Stripe will attempt to pay
        /// this subscription at the end of the cycle using the default source attached to the
        /// customer. When sending an invoice, Stripe will email your customer an invoice with
        /// payment instructions. Defaults to <c>charge_automatically</c>.
        /// </summary>
        [JsonProperty("billing")]
        public Billing? Billing { get; set; }

        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the subscription advanced to a
        /// new billing period. Pass an empty string to remove previously-defined thresholds.
        /// </summary>
        [JsonProperty("billing_thresholds")]
        public SubscriptionBillingThresholdsOptions BillingThresholds { get; set; }

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
        /// <code>end_date</code> of one phase will always equal the <code>start_date</code> of the
        /// next phase.
        /// </summary>
        [JsonProperty("phases")]
        public List<SubscriptionSchedulePhaseOptions> Phases { get; set; }

        /// <summary>
        /// Configures how the subscription schedule behaves when it ends. Possible values are
        /// <code>none</code>, <code>release</code>, or <code>renew</code>. <code>renew</code> will
        /// create a new subscription schedule revision by adding a new phase using the most recent
        /// phase’s plans applied to a duration set by <code>renewal_interval</code>.
        /// <code>none</code> will stop the subscription schedule and cancel the underlying
        /// subscription. <code>release</code> will stop the subscription schedule, but keep the
        /// underlying subscription running.
        /// </summary>
        [JsonProperty("renewal_behavior")]
        public string RenewalBehavior { get; set; }

        /// <summary>
        /// Configuration for renewing the subscription schedule when it ends. Must be set if
        /// <code>renewal_behavior</code> is <code>renew</code>. Otherwise, must not be set.
        /// </summary>
        [JsonProperty("renewal_interval")]
        public SubscriptionScheduleRenewalIntervalOptions RenewalInterval { get; set; }
    }
}
