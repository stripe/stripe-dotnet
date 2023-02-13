namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class UpcomingInvoiceOptions : BaseOptions
    {
        /// <summary>
        /// Settings for automatic tax lookup for this invoice.
        /// </summary>
        [JsonProperty("automatic_tax")]
        public InvoiceAutomaticTaxOptions AutomaticTax { get; set; }

        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Details about the customer you want to invoice.
        /// </summary>
        [JsonProperty("customer_details")]
        public InvoiceCustomerDetailsOptions CustomerDetails { get; set; }

        [JsonProperty("discounts")]
        public List<InvoiceDiscountOptions> Discounts { get; set; }

        [JsonProperty("invoice_items")]
        public List<InvoiceUpcomingInvoiceItemOptions> InvoiceItems { get; set; }

        [JsonProperty("schedule")]
        public string Schedule { get; set; }

        [JsonProperty("subscription")]
        public string Subscription { get; set; }

        [JsonProperty("subscription_billing_cycle_anchor")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, SubscriptionBillingCycleAnchor> SubscriptionBillingCycleAnchor { get; set; }

        [JsonProperty("subscription_cancel_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? SubscriptionCancelAt { get; set; }

        [JsonProperty("subscription_cancel_at_period_end")]
        public bool? SubscriptionCancelAtPeriodEnd { get; set; }

        [JsonProperty("subscription_cancel_now")]
        public bool? SubscriptionCancelNow { get; set; }

        [JsonProperty("subscription_default_tax_rates")]
        public List<string> SubscriptionDefaultTaxRates { get; set; }

        [JsonProperty("subscription_items")]
        public List<InvoiceSubscriptionItemOptions> SubscriptionItems { get; set; }

        [Obsolete("Use SubscriptionProrationBehavior instead.")]
        [JsonProperty("subscription_prorate")]
        public bool? SubscriptionProrate { get; set; }

        [JsonProperty("subscription_proration_behavior")]
        public string SubscriptionProrationBehavior { get; set; }

        [JsonProperty("subscription_proration_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? SubscriptionProrationDate { get; set; }

        [JsonProperty("subscription_resume_at")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, UpcomingInvoiceSubscriptionResumeAt> SubscriptionResumeAt { get; set; }

        [JsonProperty("subscription_start_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? SubscriptionStartDate { get; set; }

        [JsonProperty("subscription_trial_end")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, SubscriptionTrialEnd> SubscriptionTrialEnd { get; set; }

        [JsonProperty("subscription_trial_from_plan")]
        public bool? SubscriptionTrialFromPlan { get; set; }
    }
}
