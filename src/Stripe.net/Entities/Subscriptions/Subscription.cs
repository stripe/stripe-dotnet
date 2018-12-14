namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Subscription : StripeEntity, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("application_fee_percent")]
        public decimal? ApplicationFeePercent { get; set; }

        /// <summary>
        /// One of <see cref="Billing" />. When charging automatically, Stripe will attempt to pay this subscription at the end of the cycle using the default source attached to the customer. When sending an invoice, Stripe will email your customer an invoice with payment instructions.
        /// </summary>
        [JsonProperty("billing")]
        public Billing? Billing { get; set; }

        [JsonProperty("billing_cycle_anchor")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? BillingCycleAnchor { get; set; }

        [JsonProperty("cancel_at_period_end")]
        public bool CancelAtPeriodEnd { get; set; }

        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? Created { get; set; }

        [JsonProperty("current_period_end")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? CurrentPeriodEnd { get; set; }

        [JsonProperty("current_period_start")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? CurrentPeriodStart { get; set; }

        #region Expandable Customer
        [JsonIgnore]
        public string CustomerId { get; set; }

        [JsonIgnore]
        public Customer Customer { get; set; }

        [JsonProperty("customer")]
        internal object InternalCustomer
        {
            get
            {
                return this.Customer ?? (object)this.CustomerId;
            }

            set
            {
                StringOrObject<Customer>.Map(value, s => this.CustomerId = s, o => this.Customer = o);
            }
        }
        #endregion

        /// <summary>
        /// Number of days a customer has to pay invoices generated by this subscription. This value will be null for subscriptions where billing=charge_automatically.
        /// </summary>
        [JsonProperty("days_until_due")]
        public long? DaysUntilDue { get; set; }

        #region Expandable DefaultSource
        [JsonIgnore]
        public string DefaultSourceId { get; set; }

        [JsonIgnore]
        public IPaymentSource DefaultSource { get; set; }

        [JsonProperty("default_source")]
        internal object InternalDefaultSource
        {
            get
            {
                return this.DefaultSource ?? (object)this.DefaultSourceId;
            }

            set
            {
                StringOrObject<IPaymentSource>.Map(value, s => this.DefaultSourceId = s, o => this.DefaultSource = o);
            }
        }
        #endregion

        [JsonProperty("discount")]
        public Discount Discount { get; set; }

        [JsonProperty("ended_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? EndedAt { get; set; }

        [JsonProperty("items")]
        public StripeList<SubscriptionItem> Items { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("plan")]
        public Plan Plan { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("start")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? Start { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        [JsonProperty("trial_end")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? TrialEnd { get; set; }

        [JsonProperty("trial_start")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? TrialStart { get; set; }
    }
}
