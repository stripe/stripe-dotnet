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

    /// <summary>
    /// You can now model subscriptions more flexibly using the <a
    /// href="https://stripe.com/docs/api#prices">Prices API</a>. It replaces the Plans API and
    /// is backwards compatible to simplify your migration.
    ///
    /// Plans define the base price, currency, and billing cycle for recurring purchases of
    /// products. <a href="https://stripe.com/docs/api#products">Products</a> help you track
    /// inventory or provisioning, and plans help you track pricing. Different physical goods or
    /// levels of service should be represented by products, and pricing options should be
    /// represented by plans. This approach lets you change prices without having to change your
    /// provisioning scheme.
    ///
    /// For example, you might have a single "gold" product that has plans for $10/month,
    /// $100/year, €9/month, and €90/year.
    ///
    /// Related guides: <a
    /// href="https://stripe.com/docs/billing/subscriptions/set-up-subscription">Set up a
    /// subscription</a> and more about <a
    /// href="https://stripe.com/docs/products-prices/overview">products and prices</a>.
    /// </summary>
    public class Plan : StripeEntity<Plan>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif

        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif

        public string Object { get; set; }

        /// <summary>
        /// Whether the plan can be used for new purchases.
        /// </summary>
        [JsonProperty("active")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("active")]
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("aggregate_usage")]
#endif

        public string AggregateUsage { get; set; }

        /// <summary>
        /// The unit amount in cents (or local equivalent) to be charged, represented as a whole
        /// integer if possible. Only set if <c>billing_scheme=per_unit</c>.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif

        public long? Amount { get; set; }

        /// <summary>
        /// The unit amount in cents (or local equivalent) to be charged, represented as a decimal
        /// string with at most 12 decimal places. Only set if <c>billing_scheme=per_unit</c>.
        /// </summary>
        [JsonProperty("amount_decimal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_decimal")]
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_scheme")]
#endif

        public string BillingScheme { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif

        public string Currency { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("deleted")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
#endif

        public bool? Deleted { get; set; }

        /// <summary>
        /// The frequency at which a subscription is billed. One of <c>day</c>, <c>week</c>,
        /// <c>month</c> or <c>year</c>.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("interval")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("interval")]
#endif

        public string Interval { get; set; }

        /// <summary>
        /// The number of intervals (specified in the <c>interval</c> attribute) between
        /// subscription billings. For example, <c>interval=month</c> and <c>interval_count=3</c>
        /// bills every 3 months.
        /// </summary>
        [JsonProperty("interval_count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("interval_count")]
#endif

        public long IntervalCount { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif

        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif

        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The meter tracking the usage of a metered price.
        /// </summary>
        [JsonProperty("meter")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("meter")]
#endif

        public string Meter { get; set; }

        /// <summary>
        /// A brief description of the plan, hidden from customers.
        /// </summary>
        [JsonProperty("nickname")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("nickname")]
#endif

        public string Nickname { get; set; }

        #region Expandable Product

        /// <summary>
        /// (ID of the Product)
        /// The product whose pricing this plan determines.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public Product Product
        {
            get => this.InternalProduct?.ExpandedObject;
            set => this.InternalProduct = SetExpandableFieldObject(value, this.InternalProduct);
        }

        [JsonProperty("product")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product")]
        [STJS.JsonInclude]
#endif

        [JsonConverter(typeof(ExpandableFieldConverter<Product>))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Product>))]
#endif

        internal ExpandableField<Product> InternalProduct { get; set; }
        #endregion

        /// <summary>
        /// Each element represents a pricing tier. This parameter requires <c>billing_scheme</c> to
        /// be set to <c>tiered</c>. See also the documentation for <c>billing_scheme</c>.
        /// </summary>
        [JsonProperty("tiers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tiers")]
#endif

        public List<PlanTier> Tiers { get; set; }

        /// <summary>
        /// Defines if the tiering price should be <c>graduated</c> or <c>volume</c> based. In
        /// <c>volume</c>-based tiering, the maximum quantity within a period determines the per
        /// unit price. In <c>graduated</c> tiering, pricing can change as the quantity grows.
        /// One of: <c>graduated</c>, or <c>volume</c>.
        /// </summary>
        [JsonProperty("tiers_mode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tiers_mode")]
#endif

        public string TiersMode { get; set; }

        /// <summary>
        /// Apply a transformation to the reported usage or set quantity before computing the amount
        /// billed. Cannot be combined with <c>tiers</c>.
        /// </summary>
        [JsonProperty("transform_usage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transform_usage")]
#endif

        public PlanTransformUsage TransformUsage { get; set; }

        /// <summary>
        /// Default number of trial days when subscribing a customer to this plan using <a
        /// href="https://stripe.com/docs/api#create_subscription-trial_from_plan"><c>trial_from_plan=true</c></a>.
        /// </summary>
        [JsonProperty("trial_period_days")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("trial_period_days")]
#endif

        public long? TrialPeriodDays { get; set; }

        /// <summary>
        /// Configures how the quantity per period should be determined. Can be either
        /// <c>metered</c> or <c>licensed</c>. <c>licensed</c> automatically bills the
        /// <c>quantity</c> set when adding it to a subscription. <c>metered</c> aggregates the
        /// total usage based on usage records. Defaults to <c>licensed</c>.
        /// One of: <c>licensed</c>, or <c>metered</c>.
        /// </summary>
        [JsonProperty("usage_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("usage_type")]
#endif

        public string UsageType { get; set; }
    }
}
