// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceUpcomingLinesListOptions : ListOptions
    {
        /// <summary>
        /// Settings for automatic tax lookup for this invoice preview.
        /// </summary>
        [JsonProperty("automatic_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("automatic_tax")]
#endif
        public InvoiceUpcomingLinesAutomaticTaxOptions AutomaticTax { get; set; }

        /// <summary>
        /// The ID of the coupon to apply to this phase of the subscription schedule. This field has
        /// been deprecated and will be removed in a future API version. Use <c>discounts</c>
        /// instead.
        /// </summary>
        [JsonProperty("coupon")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("coupon")]
#endif
        public string Coupon { get; set; }

        /// <summary>
        /// The currency to preview this invoice in. Defaults to that of <c>customer</c> if not
        /// specified.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// The identifier of the customer whose upcoming invoice you'd like to retrieve. If
        /// <c>automatic_tax</c> is enabled then one of <c>customer</c>, <c>customer_details</c>,
        /// <c>subscription</c>, or <c>schedule</c> must be set.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// Details about the customer you want to invoice or overrides for an existing customer. If
        /// <c>automatic_tax</c> is enabled then one of <c>customer</c>, <c>customer_details</c>,
        /// <c>subscription</c>, or <c>schedule</c> must be set.
        /// </summary>
        [JsonProperty("customer_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_details")]
#endif
        public InvoiceUpcomingLinesCustomerDetailsOptions CustomerDetails { get; set; }

        /// <summary>
        /// The coupons to redeem into discounts for the invoice preview. If not specified, inherits
        /// the discount from the subscription or customer. This works for both coupons directly
        /// applied to an invoice and coupons applied to a subscription. Pass an empty string to
        /// avoid inheriting any discounts.
        /// </summary>
        [JsonProperty("discounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discounts")]
#endif
        public List<InvoiceUpcomingLinesDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// List of invoice items to add or update in the upcoming invoice preview (up to 250).
        /// </summary>
        [JsonProperty("invoice_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_items")]
#endif
        public List<InvoiceUpcomingLinesInvoiceItemOptions> InvoiceItems { get; set; }

        /// <summary>
        /// The connected account that issues the invoice. The invoice is presented with the
        /// branding and support information of the specified account.
        /// </summary>
        [JsonProperty("issuer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuer")]
#endif
        public InvoiceUpcomingLinesIssuerOptions Issuer { get; set; }

        /// <summary>
        /// The account (if any) for which the funds of the invoice payment are intended. If set,
        /// the invoice will be presented with the branding and support information of the specified
        /// account. See the <a href="https://stripe.com/docs/billing/invoices/connect">Invoices
        /// with Connect</a> documentation for details.
        /// </summary>
        [JsonProperty("on_behalf_of")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("on_behalf_of")]
#endif
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// Customizes the types of values to include when calculating the invoice. Defaults to
        /// <c>next</c> if unspecified.
        /// One of: <c>next</c>, or <c>recurring</c>.
        /// </summary>
        [JsonProperty("preview_mode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("preview_mode")]
#endif
        public string PreviewMode { get; set; }

        /// <summary>
        /// The identifier of the schedule whose upcoming invoice you'd like to retrieve. Cannot be
        /// used with subscription or subscription fields.
        /// </summary>
        [JsonProperty("schedule")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("schedule")]
#endif
        public string Schedule { get; set; }

        /// <summary>
        /// The schedule creation or modification params to apply as a preview. Cannot be used with
        /// <c>subscription</c> or <c>subscription_</c> prefixed fields.
        /// </summary>
        [JsonProperty("schedule_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("schedule_details")]
#endif
        public InvoiceUpcomingLinesScheduleDetailsOptions ScheduleDetails { get; set; }

        /// <summary>
        /// The identifier of the subscription for which you'd like to retrieve the upcoming
        /// invoice. If not provided, but a <c>subscription_details.items</c> is provided, you will
        /// preview creating a subscription with those items. If neither <c>subscription</c> nor
        /// <c>subscription_details.items</c> is provided, you will retrieve the next upcoming
        /// invoice from among the customer's subscriptions.
        /// </summary>
        [JsonProperty("subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription")]
#endif
        public string Subscription { get; set; }

        /// <summary>
        /// For new subscriptions, a future timestamp to anchor the subscription's <a
        /// href="https://stripe.com/docs/subscriptions/billing-cycle">billing cycle</a>. This is
        /// used to determine the date of the first full invoice, and, for plans with <c>month</c>
        /// or <c>year</c> intervals, the day of the month for subsequent invoices. For existing
        /// subscriptions, the value can only be set to <c>now</c> or <c>unchanged</c>. This field
        /// has been deprecated and will be removed in a future API version. Use
        /// <c>subscription_details.billing_cycle_anchor</c> instead.
        /// </summary>
        [JsonProperty("subscription_billing_cycle_anchor")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_billing_cycle_anchor")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, SubscriptionBillingCycleAnchor> SubscriptionBillingCycleAnchor { get; set; }

        /// <summary>
        /// A timestamp at which the subscription should cancel. If set to a date before the current
        /// period ends, this will cause a proration if prorations have been enabled using
        /// <c>proration_behavior</c>. If set during a future period, this will always cause a
        /// proration for that period. This field has been deprecated and will be removed in a
        /// future API version. Use <c>subscription_details.cancel_at</c> instead.
        /// </summary>
        [JsonProperty("subscription_cancel_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_cancel_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? SubscriptionCancelAt { get; set; }

        /// <summary>
        /// Indicate whether this subscription should cancel at the end of the current period
        /// (<c>current_period_end</c>). Defaults to <c>false</c>. This field has been deprecated
        /// and will be removed in a future API version. Use
        /// <c>subscription_details.cancel_at_period_end</c> instead.
        /// </summary>
        [JsonProperty("subscription_cancel_at_period_end")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_cancel_at_period_end")]
#endif
        public bool? SubscriptionCancelAtPeriodEnd { get; set; }

        /// <summary>
        /// This simulates the subscription being canceled or expired immediately. This field has
        /// been deprecated and will be removed in a future API version. Use
        /// <c>subscription_details.cancel_now</c> instead.
        /// </summary>
        [JsonProperty("subscription_cancel_now")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_cancel_now")]
#endif
        public bool? SubscriptionCancelNow { get; set; }

        /// <summary>
        /// If provided, the invoice returned will preview updating or creating a subscription with
        /// these default tax rates. The default tax rates will apply to any line item that does not
        /// have <c>tax_rates</c> set. This field has been deprecated and will be removed in a
        /// future API version. Use <c>subscription_details.default_tax_rates</c> instead.
        /// </summary>
        [JsonProperty("subscription_default_tax_rates")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_default_tax_rates")]
#endif
        public List<string> SubscriptionDefaultTaxRates { get; set; }

        /// <summary>
        /// The subscription creation or modification params to apply as a preview. Cannot be used
        /// with <c>schedule</c> or <c>schedule_details</c> fields.
        /// </summary>
        [JsonProperty("subscription_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_details")]
#endif
        public InvoiceUpcomingLinesSubscriptionDetailsOptions SubscriptionDetails { get; set; }

        /// <summary>
        /// A list of up to 20 subscription items, each with an attached price. This field has been
        /// deprecated and will be removed in a future API version. Use
        /// <c>subscription_details.items</c> instead.
        /// </summary>
        [JsonProperty("subscription_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_items")]
#endif
        public List<InvoiceUpcomingLinesSubscriptionItemOptions> SubscriptionItems { get; set; }

        /// <summary>
        /// The pre-billing to apply to the subscription as a preview. This field has been
        /// deprecated and will be removed in a future API version. Use
        /// <c>subscription_details.prebilling</c> instead.
        /// </summary>
        [JsonProperty("subscription_prebilling")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_prebilling")]
#endif
        public InvoiceUpcomingLinesSubscriptionPrebillingOptions SubscriptionPrebilling { get; set; }

        /// <summary>
        /// Determines how to handle <a
        /// href="https://stripe.com/docs/billing/subscriptions/prorations">prorations</a> when the
        /// billing cycle changes (e.g., when switching plans, resetting
        /// <c>billing_cycle_anchor=now</c>, or starting a trial), or if an item's <c>quantity</c>
        /// changes. The default value is <c>create_prorations</c>. This field has been deprecated
        /// and will be removed in a future API version. Use
        /// <c>subscription_details.proration_behavior</c> instead.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("subscription_proration_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_proration_behavior")]
#endif
        public string SubscriptionProrationBehavior { get; set; }

        /// <summary>
        /// If previewing an update to a subscription, and doing proration,
        /// <c>subscription_proration_date</c> forces the proration to be calculated as though the
        /// update was done at the specified time. The time given must be within the current
        /// subscription period and within the current phase of the schedule backing this
        /// subscription, if the schedule exists. If set, <c>subscription</c>, and one of
        /// <c>subscription_items</c>, or <c>subscription_trial_end</c> are required. Also,
        /// <c>subscription_proration_behavior</c> cannot be set to 'none'. This field has been
        /// deprecated and will be removed in a future API version. Use
        /// <c>subscription_details.proration_date</c> instead.
        /// </summary>
        [JsonProperty("subscription_proration_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_proration_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? SubscriptionProrationDate { get; set; }

        /// <summary>
        /// For paused subscriptions, setting <c>subscription_resume_at</c> to <c>now</c> will
        /// preview the invoice that will be generated if the subscription is resumed. This field
        /// has been deprecated and will be removed in a future API version. Use
        /// <c>subscription_details.resume_at</c> instead.
        /// </summary>
        [JsonProperty("subscription_resume_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_resume_at")]
#endif
        public string SubscriptionResumeAt { get; set; }

        /// <summary>
        /// Date a subscription is intended to start (can be future or past). This field has been
        /// deprecated and will be removed in a future API version. Use
        /// <c>subscription_details.start_date</c> instead.
        /// </summary>
        [JsonProperty("subscription_start_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_start_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? SubscriptionStartDate { get; set; }

        /// <summary>
        /// If provided, the invoice returned will preview updating or creating a subscription with
        /// that trial end. If set, one of <c>subscription_items</c> or <c>subscription</c> is
        /// required. This field has been deprecated and will be removed in a future API version.
        /// Use <c>subscription_details.trial_end</c> instead.
        /// </summary>
        [JsonProperty("subscription_trial_end")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_trial_end")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_trial_from_plan")]
#endif
        public bool? SubscriptionTrialFromPlan { get; set; }
    }
}
