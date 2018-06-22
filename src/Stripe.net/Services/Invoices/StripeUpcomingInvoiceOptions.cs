using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;
using System.Collections.Generic;

namespace Stripe
{
    public class StripeUpcomingInvoiceOptions : StripeBaseOptions
    {
        [JsonProperty("coupon")]
        public string CouponId { get; set; }

        [JsonProperty("invoice_items")]
        public List<StripeInvoiceUpcomingInvoiceItemOption> InvoiceItems { get; set; }

        /// <summary>
        /// A future date to anchor the subscription’s <see href="https://stripe.com/docs/subscriptions/billing-cycle">billing cycle</see>. This is used to determine the date of the first full invoice, and, for plans with <c>month</c> or <c>year</c> intervals, the day of the month for subsequent invoices.
        /// </summary>
        public DateTime? SubscriptionBillingCycleAnchor { get; set; }

        [JsonProperty("subscription_billing_cycle_anchor")]
        internal long? SubscriptionBillingCycleAnchorInternal
        {
            get
            {
                if (!SubscriptionBillingCycleAnchor.HasValue) return null;

                return EpochTime.ConvertDateTimeToEpoch(SubscriptionBillingCycleAnchor.Value);
            }
        }

        [JsonProperty("subscription")]
        public string SubscriptionId { get; set; }

        [JsonProperty("subscription_items")]
        public List<StripeInvoiceSubscriptionItemOptions> SubscriptionItems { get; set; }

        [JsonProperty("subscription_plan")]
        public string SubscriptionPlanId { get; set; }

        [JsonProperty("subscription_prorate")]
        public bool? SubscriptionProrate { get; set; }

        public DateTime? SubscriptionProrationDate { get; set; }

        [JsonProperty("subscription_proration_date")]
        internal long? SubscriptionProrationDateInternal
        {
            get
            {
                if (!SubscriptionProrationDate.HasValue)
                    return null;

                return EpochTime.ConvertDateTimeToEpoch(SubscriptionProrationDate.Value);
            }
        }

        [JsonProperty("subscription_quantity")]
        public int? SubscriptionQuantity { get; set; }

        [JsonProperty("subscription_tax_percent")]
        public decimal? SubscriptionTaxPercent { get; set; }

        public DateTime? SubscriptionTrialEnd { get; set; }

        [JsonProperty("subscription_trial_end")]
        internal long? SubscriptionTrialEndInternal
        {
            get
            {
                if (!SubscriptionTrialEnd.HasValue)
                    return null;

                return EpochTime.ConvertDateTimeToEpoch(SubscriptionTrialEnd.Value);
            }
        }

        [JsonProperty("subscription_trial_from_plan")]
        public bool? SubscriptionTrialFromPlan { get; set; }
    }
}
