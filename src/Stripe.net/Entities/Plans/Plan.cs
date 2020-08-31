namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Plan : StripeEntity<Plan>, IHasId, IHasMetadata, IHasObject
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
        /// Whether the plan can be used for new purchases.
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Specifies a usage aggregation strategy for plans of <c>usage_type=metered</c>. Allowed
        /// values are <c>sum</c> for summing up all usage during a period,
        /// <c>last_during_period</c> for using the last usage record reported within a period,
        /// <c>last_ever</c> for using the last usage record ever (across period bounds) or
        /// <c>max</c> which uses the usage record with the maximum reported usage during a period.
        /// Defaults to <c>sum</c>.
        /// One of: <c>last_during_period</c>, <c>last_ever</c>, <c>max</c>, or <c>sum</c>.
        /// </summary>
        [JsonProperty("aggregate_usage")]
        public string AggregateUsage { get; set; }

        /// <summary>
        /// The unit amount in %s to be charged, represented as a whole integer if possible.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The unit amount in %s to be charged, represented as a decimal string with at most 12
        /// decimal places.
        /// </summary>
        [JsonProperty("amount_decimal")]
        public decimal? AmountDecimal { get; set; }

        /// <summary>
        /// Describes how to compute the price per period. Either <c>per_unit</c> or <c>tiered</c>.
        /// <c>per_unit</c> indicates that the fixed amount (specified in <c>amount</c>) will be
        /// charged per unit in <c>quantity</c> (for plans with <c>usage_type=licensed</c>), or per
        /// unit of total usage (for plans with <c>usage_type=metered</c>). <c>tiered</c> indicates
        /// that the unit pricing will be computed using a tiering strategy as defined using the
        /// <c>tiers</c> and <c>tiers_mode</c> attributes.
        /// One of: <c>per_unit</c>, or <c>tiered</c>.
        /// </summary>
        [JsonProperty("billing_scheme")]
        public string BillingScheme { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// The frequency at which a subscription is billed. One of <c>day</c>, <c>week</c>,
        /// <c>month</c> or <c>year</c>.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// The number of intervals (specified in the <c>interval</c> attribute) between
        /// subscription billings. For example, <c>interval=month</c> and <c>interval_count=3</c>
        /// bills every 3 months.
        /// </summary>
        [JsonProperty("interval_count")]
        public long IntervalCount { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A brief description of the plan, hidden from customers.
        /// </summary>
        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        #region Expandable Product

        /// <summary>
        /// (ID of the Product)
        /// The product whose pricing this plan determines.
        /// </summary>
        [JsonIgnore]
        public string ProductId
        {
            get => this.InternalProduct?.Id;
            set => this.InternalProduct = SetExpandableFieldId(value, this.InternalProduct);
        }

        /// <summary>
        /// (Expanded)
        /// The product whose pricing this plan determines.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Product Product
        {
            get => this.InternalProduct?.ExpandedObject;
            set => this.InternalProduct = SetExpandableFieldObject(value, this.InternalProduct);
        }

        [JsonProperty("product")]
        [JsonConverter(typeof(ExpandableFieldConverter<Product>))]
        internal ExpandableField<Product> InternalProduct { get; set; }
        #endregion

        /// <summary>
        /// Each element represents a pricing tier. This parameter requires <c>billing_scheme</c> to
        /// be set to <c>tiered</c>. See also the documentation for <c>billing_scheme</c>.
        /// </summary>
        [JsonProperty("tiers")]
        public List<PlanTier> Tiers { get; set; }

        /// <summary>
        /// Defines if the tiering price should be <c>graduated</c> or <c>volume</c> based. In
        /// <c>volume</c>-based tiering, the maximum quantity within a period determines the per
        /// unit price. In <c>graduated</c> tiering, pricing can change as the quantity grows.
        /// One of: <c>graduated</c>, or <c>volume</c>.
        /// </summary>
        [JsonProperty("tiers_mode")]
        public string TiersMode { get; set; }

        /// <summary>
        /// Apply a transformation to the reported usage or set quantity before computing the amount
        /// billed. Cannot be combined with <c>tiers</c>.
        /// </summary>
        [JsonProperty("transform_usage")]
        public PlanTransformUsage TransformUsage { get; set; }

        /// <summary>
        /// Default number of trial days when subscribing a customer to this plan using <a
        /// href="https://stripe.com/docs/api#create_subscription-trial_from_plan"><c>trial_from_plan=true</c></a>.
        /// </summary>
        [JsonProperty("trial_period_days")]
        public long? TrialPeriodDays { get; set; }

        /// <summary>
        /// Configures how the quantity per period should be determined. Can be either
        /// <c>metered</c> or <c>licensed</c>. <c>licensed</c> automatically bills the
        /// <c>quantity</c> set when adding it to a subscription. <c>metered</c> aggregates the
        /// total usage based on usage records. Defaults to <c>licensed</c>.
        /// One of: <c>licensed</c>, or <c>metered</c>.
        /// </summary>
        [JsonProperty("usage_type")]
        public string UsageType { get; set; }
    }
}
