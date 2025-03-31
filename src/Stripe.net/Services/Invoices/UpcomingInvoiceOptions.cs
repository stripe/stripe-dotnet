namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    using Stripe.Infrastructure;

    public class UpcomingInvoiceOptions : BaseOptions
    {
        /// <summary>
        /// Settings for automatic tax lookup for this invoice.
        /// </summary>
        [JsonProperty("automatic_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("automatic_tax")]
#endif
        public InvoiceAutomaticTaxOptions AutomaticTax { get; set; }

        [JsonProperty("coupon")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("coupon")]
#endif
        public string Coupon { get; set; }

        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// Details about the customer you want to invoice.
        /// </summary>
        [JsonProperty("customer_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_details")]
#endif
        public InvoiceCustomerDetailsOptions CustomerDetails { get; set; }

        [JsonProperty("discounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discounts")]
#endif
        public List<InvoiceDiscountOptions> Discounts { get; set; }

        [JsonProperty("invoice_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_items")]
#endif
        public List<InvoiceUpcomingInvoiceItemOptions> InvoiceItems { get; set; }

        [JsonProperty("schedule")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("schedule")]
#endif
        public string Schedule { get; set; }

        [JsonProperty("subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription")]
#endif
        public string Subscription { get; set; }

        [JsonProperty("subscription_billing_cycle_anchor")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_billing_cycle_anchor")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, SubscriptionBillingCycleAnchor> SubscriptionBillingCycleAnchor { get; set; }

        [JsonProperty("subscription_cancel_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_cancel_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? SubscriptionCancelAt { get; set; }

        [JsonProperty("subscription_cancel_at_period_end")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_cancel_at_period_end")]
#endif
        public bool? SubscriptionCancelAtPeriodEnd { get; set; }

        [JsonProperty("subscription_cancel_now")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_cancel_now")]
#endif
        public bool? SubscriptionCancelNow { get; set; }

        [JsonProperty("subscription_default_tax_rates")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_default_tax_rates")]
#endif
        public List<string> SubscriptionDefaultTaxRates { get; set; }

        [Obsolete("Use SubscriptionProrationBehavior instead.")]
        [JsonProperty("subscription_prorate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_prorate")]
#endif
        public bool? SubscriptionProrate { get; set; }

        [JsonProperty("subscription_proration_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_proration_behavior")]
#endif
        public string SubscriptionProrationBehavior { get; set; }

        [JsonProperty("subscription_proration_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_proration_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? SubscriptionProrationDate { get; set; }

        [JsonProperty("subscription_resume_at")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_resume_at")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, UpcomingInvoiceSubscriptionResumeAt> SubscriptionResumeAt { get; set; }

        [JsonProperty("subscription_start_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_start_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? SubscriptionStartDate { get; set; }

        [JsonProperty("subscription_trial_end")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_trial_end")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, SubscriptionTrialEnd> SubscriptionTrialEnd { get; set; }

        [JsonProperty("subscription_trial_from_plan")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_trial_from_plan")]
#endif
        public bool? SubscriptionTrialFromPlan { get; set; }
    }
}
