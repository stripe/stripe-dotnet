// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class QuotePhaseOptions : INestedOptions
    {
        /// <summary>
        /// When specified as <c>reset</c>, the subscription will always start a new billing period
        /// when the quote is accepted.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        public string BillingCycleAnchor { get; set; }

        /// <summary>
        /// Either <c>charge_automatically</c>, or <c>send_invoice</c>. When charging automatically,
        /// Stripe will attempt to pay the underlying subscription at the end of each billing cycle
        /// using the default source attached to the customer. When sending an invoice, Stripe will
        /// email your customer an invoice with payment instructions and mark the subscription as
        /// <c>active</c>. Defaults to <c>charge_automatically</c> on creation.
        /// One of: <c>charge_automatically</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        /// <summary>
        /// A list of <a href="https://stripe.com/docs/api/tax_rates">Tax Rate</a> ids. These Tax
        /// Rates will set the Subscription's <a
        /// href="https://stripe.com/docs/api/subscriptions/create#create_subscription-default_tax_rates"><c>default_tax_rates</c></a>,
        /// which means they will be the Invoice's <a
        /// href="https://stripe.com/docs/api/invoices/create#create_invoice-default_tax_rates"><c>default_tax_rates</c></a>
        /// for any Invoices issued by the Subscription during this Phase.
        /// </summary>
        [JsonProperty("default_tax_rates")]
        public List<string> DefaultTaxRates { get; set; }

        /// <summary>
        /// The coupons to redeem into discounts for the schedule phase. If not specified, inherits
        /// the discount from the subscription's customer. Pass an empty string to avoid inheriting
        /// any discounts.
        /// </summary>
        [JsonProperty("discounts")]
        public List<QuotePhaseDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// The date at which this phase of the quote ends. If set, <c>iterations</c> must not be
        /// set.
        /// </summary>
        [JsonProperty("end_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// All invoices will be billed using the specified settings.
        /// </summary>
        [JsonProperty("invoice_settings")]
        public QuotePhaseInvoiceSettingsOptions InvoiceSettings { get; set; }

        /// <summary>
        /// Integer representing the multiplier applied to the price interval. For example,
        /// <c>iterations=2</c> applied to a price with <c>interval=month</c> and
        /// <c>interval_count=3</c> results in a phase of duration <c>2 * 3 months = 6 months</c>.
        /// If set, <c>end_date</c> must not be set.
        /// </summary>
        [JsonProperty("iterations")]
        public long? Iterations { get; set; }

        /// <summary>
        /// A list of line items the customer is being quoted for within this phase. Each line item
        /// includes information about the product, the quantity, and the resulting cost.
        /// </summary>
        [JsonProperty("line_items")]
        public List<QuotePhaseLineItemOptions> LineItems { get; set; }

        /// <summary>
        /// If the update changes the current phase, indicates whether the changes should be
        /// prorated. The default value is <c>create_prorations</c>.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// If set to true the entire phase is counted as a trial and the customer will not be
        /// charged for any fees.
        /// </summary>
        [JsonProperty("trial")]
        public bool? Trial { get; set; }

        /// <summary>
        /// Sets the phase to trialing from the start date to this date. Must be before the phase
        /// end date, can not be combined with <c>trial</c>.
        /// </summary>
        [JsonProperty("trial_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? TrialEnd { get; set; }
    }
}
