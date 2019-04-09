namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class UpcomingInvoiceListLineItemsOptions : ListOptions
    {
        /// <summary>
        /// The code of the coupon to apply. If <c>subscription</c> or <c>subscription_items</c> is
        /// provided, the invoice returned will preview updating or creating a subscription with
        /// that coupon. Otherwise, it will preview applying that coupon to the customer for the
        /// next upcoming invoice from among the customer’s subscriptions. The invoice can be
        /// previewed without a coupon by passing this value as an empty string.
        /// </summary>
        [JsonProperty("coupon")]
        public string CouponId { get; set; }

        /// <summary>
        /// REQUIRED
        /// </summary>
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        /// <summary>
        /// List of invoice items to add or update in the upcoming invoice preview.
        /// </summary>
        [JsonProperty("invoice_items")]
        public List<InvoiceUpcomingInvoiceItemOption> InvoiceItems { get; set; }

        #region SubscriptionBillingCycleAnchor

        /// <summary>
        /// For new subscriptions, a future timestamp to anchor the subscription’s
        /// <see href="https://stripe.com/docs/subscriptions/billing-cycle">billing cycle</see>.
        /// This is used to determine the date of the first full invoice, and, for plans with
        /// <c>month</c> or <c>year</c> intervals, the day of the month for subsequent invoices.For
        /// existing subscriptions, the value can only be set to <c>now</c> or <c>unchanged</c>.
        /// </summary>
        public DateTime? SubscriptionBillingCycleAnchor { get; set; }

        public bool SubscriptionBillingCycleAnchorNow { get; set; }

        public bool SubscriptionBillingCycleAnchorUnchanged { get; set; }

        [JsonProperty("subscription_billing_cycle_anchor")]
        internal string SubscriptionBillingCycleAnchorInternal
        {
            get
            {
                if (this.SubscriptionBillingCycleAnchorNow)
                {
                    return "now";
                }

                if (this.SubscriptionBillingCycleAnchorUnchanged)
                {
                    return "unchanged";
                }

                return this.SubscriptionBillingCycleAnchor?.ConvertDateTimeToEpoch().ToString();
            }
        }
        #endregion

        /// <summary>
        /// Boolean indicating whether this subscription should cancel at the end of the current
        /// period.
        /// </summary>
        [JsonProperty("subscription_cancel_at_period_end")]
        public bool? SubscriptionCancelAtPeriodEnd { get; set; }

        /// <summary>
        /// The identifier of the subscription for which you’d like to retrieve the upcoming
        /// invoice. If not provided, but a <c>subscription_items</c> is provided, you will preview
        /// creating a subscription with those items. If neither <c>subscription</c> nor
        /// <c>subscription_items</c> is provided, you will retrieve the next upcoming invoice from
        /// among the customer’s subscriptions.
        /// </summary>
        [JsonProperty("subscription")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// List of subscription items, each with an attached plan.
        /// </summary>
        [JsonProperty("subscription_items")]
        public List<InvoiceSubscriptionItemOptions> SubscriptionItems { get; set; }

        /// <summary>
        /// If previewing an update to a subscription, this decides whether the preview will show
        /// the result of applying prorations or not. If set, one of <c>subscription_items</c> or
        /// <c>subscription</c>, and one of <c>subscription_items</c> or
        /// <c>subscription_trial_end</c> are required.
        /// </summary>
        [JsonProperty("subscription_prorate")]
        public bool? SubscriptionProrate { get; set; }

        /// <summary>
        /// If previewing an update to a subscription, and doing proration,
        /// <c>subscription_proration_date</c> forces the proration to be calculated as though the
        /// update was done at the specified time. The time given must be within the current
        /// subscription period, and cannot be before the subscription was on its current plan. If
        /// set, <c>subscription</c>, and one of <c>subscription_items</c>, or
        /// <c>subscription_trial_end</c> are required. Also, <c>subscription_proration</c> cannot
        /// be set to false.
        /// </summary>
        [JsonProperty("subscription_proration_date")]
        public DateTime? SubscriptionProrationDate { get; set; }

        /// <summary>
        /// If provided, the invoice returned will preview updating or creating a subscription with
        /// that tax percent. If set, one of <c>subscription_items</c> or
        /// <c>subscription is required</c>.
        /// </summary>
        [Obsolete("Use SubscriptionTaxRates")]
        [JsonProperty("subscription_tax_percent")]
        public decimal? SubscriptionTaxPercent { get; set; }

        /// <summary>
        /// If provided, the invoice returned will preview updating or creating a subscription with
        /// those tax rates applied.
        /// </summary>
        [JsonProperty("subscription_tax_rates")]
        public List<TaxRate> SubscriptionTaxRates { get; set; }

        /// <summary>
        /// If provided, the invoice returned will preview updating or creating a subscription with
        /// that trial end. If set, one of <c>subscription_items</c> or <c>subscription</c> is
        /// required.
        /// </summary>
        [JsonProperty("subscription_trial_end")]
        public DateTime? SubscriptionTrialEnd { get; set; }

        /// <summary>
        /// Indicates if a plan’s <c>trial_period_days</c> should be applied to the subscription.
        /// Setting <c>subscription_trial_end</c> per subscription is preferred, and this defaults
        /// to <c>false</c>. Setting this flag to <c>true</c> together with
        /// <c>subscription_trial_end</c> is not allowed.
        /// </summary>
        [JsonProperty("subscription_trial_from_plan")]
        public bool? SubscriptionTrialFromPlan { get; set; }
    }
}
