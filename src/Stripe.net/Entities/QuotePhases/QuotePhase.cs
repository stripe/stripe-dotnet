// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A quote phase describes the line items, coupons, and trialing status of a subscription
    /// for a predefined time period.
    /// </summary>
    public class QuotePhase : StripeEntity<QuotePhase>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Total before any discounts or taxes are applied.
        /// </summary>
        [JsonProperty("amount_subtotal")]
        public long AmountSubtotal { get; set; }

        /// <summary>
        /// Total after discounts and taxes are applied.
        /// </summary>
        [JsonProperty("amount_total")]
        public long AmountTotal { get; set; }

        /// <summary>
        /// If set to <c>new</c>, the billing_cycle_anchor of the subscription is set to the start
        /// of the phase when entering the phase. If unset, then the billing cycle anchor is
        /// automatically modified as needed when entering the phase. For more information, see the
        /// billing cycle <a
        /// href="https://stripe.com/docs/billing/subscriptions/billing-cycle">documentation</a>.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        public string BillingCycleAnchor { get; set; }

        /// <summary>
        /// Either <c>charge_automatically</c>, or <c>send_invoice</c>. When charging automatically,
        /// Stripe will attempt to pay the underlying subscription at the end of each billing cycle
        /// using the default source attached to the customer. When sending an invoice, Stripe will
        /// email your customer an invoice with payment instructions.
        /// One of: <c>charge_automatically</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        #region Expandable DefaultTaxRates

        /// <summary>
        /// (IDs of the DefaultTaxRates)
        /// The default tax rates to apply to the subscription during this phase of the quote.
        /// </summary>
        [JsonIgnore]
        public List<string> DefaultTaxRateIds
        {
            get => this.InternalDefaultTaxRates?.Select((x) => x.Id).ToList();
            set => this.InternalDefaultTaxRates = SetExpandableArrayIds<TaxRate>(value);
        }

        /// <summary>
        /// (Expanded)
        /// The default tax rates to apply to the subscription during this phase of the quote.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public List<TaxRate> DefaultTaxRates
        {
            get => this.InternalDefaultTaxRates?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalDefaultTaxRates = SetExpandableArrayObjects(value);
        }

        [JsonProperty("default_tax_rates", ItemConverterType = typeof(ExpandableFieldConverter<TaxRate>))]
        internal List<ExpandableField<TaxRate>> InternalDefaultTaxRates { get; set; }
        #endregion

        #region Expandable Discounts

        /// <summary>
        /// (IDs of the Discounts)
        /// The stackable discounts that will be applied to the subscription on this phase.
        /// Subscription item discounts are applied before subscription discounts.
        /// </summary>
        [JsonIgnore]
        public List<string> DiscountIds
        {
            get => this.InternalDiscounts?.Select((x) => x.Id).ToList();
            set => this.InternalDiscounts = SetExpandableArrayIds<Discount>(value);
        }

        /// <summary>
        /// (Expanded)
        /// The stackable discounts that will be applied to the subscription on this phase.
        /// Subscription item discounts are applied before subscription discounts.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public List<Discount> Discounts
        {
            get => this.InternalDiscounts?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalDiscounts = SetExpandableArrayObjects(value);
        }

        [JsonProperty("discounts", ItemConverterType = typeof(ExpandableFieldConverter<Discount>))]
        internal List<ExpandableField<Discount>> InternalDiscounts { get; set; }
        #endregion

        /// <summary>
        /// The end of this phase of the quote.
        /// </summary>
        [JsonProperty("end_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The invoice settings applicable during this phase.
        /// </summary>
        [JsonProperty("invoice_settings")]
        public QuotePhaseInvoiceSettings InvoiceSettings { get; set; }

        /// <summary>
        /// Integer representing the multiplier applied to the price interval. For example,
        /// <c>iterations=2</c> applied to a price with <c>interval=month</c> and
        /// <c>interval_count=3</c> results in a phase of duration <c>2 * 3 months = 6 months</c>.
        /// </summary>
        [JsonProperty("iterations")]
        public long? Iterations { get; set; }

        /// <summary>
        /// A list of items the customer is being quoted for.
        /// </summary>
        [JsonProperty("line_items")]
        public StripeList<LineItem> LineItems { get; set; }

        /// <summary>
        /// If the quote will prorate when transitioning to this phase. Possible values are
        /// <c>create_prorations</c> and <c>none</c>.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }

        [JsonProperty("total_details")]
        public QuotePhaseTotalDetails TotalDetails { get; set; }

        /// <summary>
        /// If set to true the entire phase is counted as a trial and the customer will not be
        /// charged for any recurring fees.
        /// </summary>
        [JsonProperty("trial")]
        public bool? Trial { get; set; }

        /// <summary>
        /// When the trial ends within the phase.
        /// </summary>
        [JsonProperty("trial_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? TrialEnd { get; set; }
    }
}
