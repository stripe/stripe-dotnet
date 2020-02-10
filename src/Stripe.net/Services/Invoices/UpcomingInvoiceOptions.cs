namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class UpcomingInvoiceOptions : BaseOptions
    {
        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("invoice_items")]
        public List<InvoiceUpcomingInvoiceItemOptions> InvoiceItems { get; set; }

        [JsonProperty("schedule")]
        public string Schedule { get; set; }

        [JsonProperty("subscription_billing_cycle_anchor")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, SubscriptionBillingCycleAnchor> SubscriptionBillingCycleAnchor { get; set; }

        [JsonProperty("subscription_cancel_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? SubscriptionCancelAt { get; set; }

        [JsonProperty("subscription_cancel_at_period_end")]
        public bool? SubscriptionCancelAtPeriodEnd { get; set; }

        [JsonProperty("subscription_cancel_now")]
        public bool? SubscriptionCancelNow { get; set; }

        [JsonProperty("subscription_default_tax_rates")]
        public List<string> SubscriptionDefaultTaxRates { get; set; }

        [JsonProperty("subscription")]
        public string Subscription { get; set; }

        [JsonProperty("subscription_items")]
        public List<InvoiceSubscriptionItemOptions> SubscriptionItems { get; set; }

        [JsonProperty("subscription_prorate")]
        public bool? SubscriptionProrate { get; set; }

        [JsonProperty("subscription_proration_behavior")]
        public string SubscriptionProrationBehavior { get; set; }

        [JsonProperty("subscription_proration_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? SubscriptionProrationDate { get; set; }

        [Obsolete("Use SubscriptionDefaultTaxRates")]
        [JsonProperty("subscription_tax_percent")]
        public decimal? SubscriptionTaxPercent { get; set; }

        [JsonProperty("subscription_trial_end")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? SubscriptionTrialEnd { get; set; }

        [JsonProperty("subscription_trial_from_plan")]
        public bool? SubscriptionTrialFromPlan { get; set; }
    }
}
