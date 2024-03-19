// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class UpcomingInvoiceListLineItemsOptions : ListOptions
    {
        /// <summary>
        /// Settings for automatic tax lookup for this invoice preview.
        /// </summary>
        [JsonProperty("automatic_tax")]
        public InvoiceAutomaticTaxOptions AutomaticTax { get; set; }

        /// <summary>
        /// The code of the coupon to apply. If <c>subscription</c> or <c>subscription_items</c> is
        /// provided, the invoice returned will preview updating or creating a subscription with
        /// that coupon. Otherwise, it will preview applying that coupon to the customer for the
        /// next upcoming invoice from among the customer's subscriptions. The invoice can be
        /// previewed without a coupon by passing this value as an empty string.
        /// </summary>
        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// The currency to preview this invoice in. Defaults to that of <c>customer</c> if not
        /// specified.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The identifier of the customer whose upcoming invoice you'd like to retrieve. If
        /// <c>automatic_tax</c> is enabled then one of <c>customer</c>, <c>customer_details</c>,
        /// <c>subscription</c>, or <c>schedule</c> must be set.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Details about the customer you want to invoice or overrides for an existing customer. If
        /// <c>automatic_tax</c> is enabled then one of <c>customer</c>, <c>customer_details</c>,
        /// <c>subscription</c>, or <c>schedule</c> must be set.
        /// </summary>
        [JsonProperty("customer_details")]
        public InvoiceCustomerDetailsOptions CustomerDetails { get; set; }

        /// <summary>
        /// The coupons to redeem into discounts for the invoice preview. If not specified, inherits
        /// the discount from the customer or subscription. This only works for coupons directly
        /// applied to the invoice. To apply a coupon to a subscription, you must use the
        /// <c>coupon</c> parameter instead. Pass an empty string to avoid inheriting any discounts.
        /// To preview the upcoming invoice for a subscription that hasn't been created, use
        /// <c>coupon</c> instead.
        /// </summary>
        [JsonProperty("discounts")]
        public List<InvoiceDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// List of invoice items to add or update in the upcoming invoice preview.
        /// </summary>
        [JsonProperty("invoice_items")]
        public List<InvoiceUpcomingInvoiceItemOptions> InvoiceItems { get; set; }

        /// <summary>
        /// The connected account that issues the invoice. The invoice is presented with the
        /// branding and support information of the specified account.
        /// </summary>
        [JsonProperty("issuer")]
        public InvoiceIssuerOptions Issuer { get; set; }

        /// <summary>
        /// The account (if any) for which the funds of the invoice payment are intended. If set,
        /// the invoice will be presented with the branding and support information of the specified
        /// account. See the <a href="https://stripe.com/docs/billing/invoices/connect">Invoices
        /// with Connect</a> documentation for details.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// The identifier of the schedule whose upcoming invoice you'd like to retrieve. Cannot be
        /// used with subscription or subscription fields.
        /// </summary>
        [JsonProperty("schedule")]
        public string Schedule { get; set; }

        /// <summary>
        /// The identifier of the subscription for which you'd like to retrieve the upcoming
        /// invoice. If not provided, but a <c>subscription_items</c> is provided, you will preview
        /// creating a subscription with those items. If neither <c>subscription</c> nor
        /// <c>subscription_items</c> is provided, you will retrieve the next upcoming invoice from
        /// among the customer's subscriptions.
        /// </summary>
        [JsonProperty("subscription")]
        public string Subscription { get; set; }

        /// <summary>
        /// For new subscriptions, a future timestamp to anchor the subscription's <a
        /// href="https://stripe.com/docs/subscriptions/billing-cycle">billing cycle</a>. This is
        /// used to determine the date of the first full invoice, and, for plans with <c>month</c>
        /// or <c>year</c> intervals, the day of the month for subsequent invoices. For existing
        /// subscriptions, the value can only be set to <c>now</c> or <c>unchanged</c>.
        /// </summary>
        [JsonProperty("subscription_billing_cycle_anchor")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, SubscriptionBillingCycleAnchor> SubscriptionBillingCycleAnchor { get; set; }

        /// <summary>
        /// A timestamp at which the subscription should cancel. If set to a date before the current
        /// period ends, this will cause a proration if prorations have been enabled using
        /// <c>proration_behavior</c>. If set during a future period, this will always cause a
        /// proration for that period.
        /// </summary>
        [JsonProperty("subscription_cancel_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? SubscriptionCancelAt { get; set; }

        /// <summary>
        /// Boolean indicating whether this subscription should cancel at the end of the current
        /// period.
        /// </summary>
        [JsonProperty("subscription_cancel_at_period_end")]
        public bool? SubscriptionCancelAtPeriodEnd { get; set; }

        /// <summary>
        /// This simulates the subscription being canceled or expired immediately.
        /// </summary>
        [JsonProperty("subscription_cancel_now")]
        public bool? SubscriptionCancelNow { get; set; }

        /// <summary>
        /// If provided, the invoice returned will preview updating or creating a subscription with
        /// these default tax rates. The default tax rates will apply to any line item that does not
        /// have <c>tax_rates</c> set.
        /// </summary>
        [JsonProperty("subscription_default_tax_rates")]
        public List<string> SubscriptionDefaultTaxRates { get; set; }

        /// <summary>
        /// A list of up to 20 subscription items, each with an attached price.
        /// </summary>
        [JsonProperty("subscription_items")]
        public List<InvoiceSubscriptionItemOptions> SubscriptionItems { get; set; }

        [Obsolete("Use SubscriptionProrationBehavior instead.")]
        [JsonProperty("subscription_prorate")]
        public bool? SubscriptionProrate { get; set; }

        /// <summary>
        /// Determines how to handle <a
        /// href="https://stripe.com/docs/billing/subscriptions/prorations">prorations</a> when the
        /// billing cycle changes (e.g., when switching plans, resetting
        /// <c>billing_cycle_anchor=now</c>, or starting a trial), or if an item's <c>quantity</c>
        /// changes. The default value is <c>create_prorations</c>.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("subscription_proration_behavior")]
        public string SubscriptionProrationBehavior { get; set; }

        /// <summary>
        /// If previewing an update to a subscription, and doing proration,
        /// <c>subscription_proration_date</c> forces the proration to be calculated as though the
        /// update was done at the specified time. The time given must be within the current
        /// subscription period and within the current phase of the schedule backing this
        /// subscription, if the schedule exists. If set, <c>subscription</c>, and one of
        /// <c>subscription_items</c>, or <c>subscription_trial_end</c> are required. Also,
        /// <c>subscription_proration_behavior</c> cannot be set to 'none'.
        /// </summary>
        [JsonProperty("subscription_proration_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? SubscriptionProrationDate { get; set; }

        /// <summary>
        /// For paused subscriptions, setting <c>subscription_resume_at</c> to <c>now</c> will
        /// preview the invoice that will be generated if the subscription is resumed.
        /// </summary>
        [JsonProperty("subscription_resume_at")]
        public string SubscriptionResumeAt { get; set; }

        /// <summary>
        /// Date a subscription is intended to start (can be future or past).
        /// </summary>
        [JsonProperty("subscription_start_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? SubscriptionStartDate { get; set; }

        /// <summary>
        /// If provided, the invoice returned will preview updating or creating a subscription with
        /// that trial end. If set, one of <c>subscription_items</c> or <c>subscription</c> is
        /// required.
        /// </summary>
        [JsonProperty("subscription_trial_end")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, SubscriptionTrialEnd> SubscriptionTrialEnd { get; set; }

        /// <summary>
        /// Indicates if a plan's <c>trial_period_days</c> should be applied to the subscription.
        /// Setting <c>subscription_trial_end</c> per subscription is preferred, and this defaults
        /// to <c>false</c>. Setting this flag to <c>true</c> together with
        /// <c>subscription_trial_end</c> is not allowed. See <a
        /// href="https://stripe.com/docs/billing/subscriptions/trials">Using trial periods on
        /// subscriptions</a> to learn more.
        /// </summary>
        [JsonProperty("subscription_trial_from_plan")]
        public bool? SubscriptionTrialFromPlan { get; set; }
    }
}
