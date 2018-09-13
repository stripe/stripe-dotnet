namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class StripeUpcomingInvoiceOptions : StripeBaseOptions
    {
        [JsonProperty("coupon")]
        public string CouponId { get; set; }

        [JsonProperty("invoice_items")]
        public List<StripeInvoiceUpcomingInvoiceItemOption> InvoiceItems { get; set; }

        /// <summary>
        /// A future date to anchor the subscription’s <see href="https://stripe.com/docs/subscriptions/billing-cycle">billing cycle</see>. This is used to determine the date of the first full invoice, and, for plans with <c>month</c> or <c>year</c> intervals, the day of the month for subsequent invoices.
        /// </summary>
        [JsonProperty("subscription_billing_cycle_anchor")]
        public DateTime? SubscriptionBillingCycleAnchor { get; set; }

        [JsonProperty("subscription")]
        public string SubscriptionId { get; set; }

        [JsonProperty("subscription_items")]
        public List<StripeInvoiceSubscriptionItemOptions> SubscriptionItems { get; set; }

        [JsonProperty("subscription_plan")]
        public string SubscriptionPlanId { get; set; }

        [JsonProperty("subscription_prorate")]
        public bool? SubscriptionProrate { get; set; }

        [JsonProperty("subscription_proration_date")]
        public DateTime? SubscriptionProrationDate { get; set; }

        [JsonProperty("subscription_quantity")]
        public int? SubscriptionQuantity { get; set; }

        [JsonProperty("subscription_tax_percent")]
        public decimal? SubscriptionTaxPercent { get; set; }

        [JsonProperty("subscription_trial_end")]
        public DateTime? SubscriptionTrialEnd { get; set; }

        [JsonProperty("subscription_trial_from_plan")]
        public bool? SubscriptionTrialFromPlan { get; set; }
    }
}
