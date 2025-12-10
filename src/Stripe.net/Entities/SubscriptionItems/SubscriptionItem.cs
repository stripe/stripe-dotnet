// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Subscription items allow you to create customer subscriptions with more than one plan,
    /// making it easy to represent complex billing relationships.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class SubscriptionItem : StripeEntity<SubscriptionItem>, IHasId, IHasMetadata, IHasObject
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
        /// The time period the subscription item has been billed for.
        /// </summary>
        [JsonProperty("billed_until")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billed_until")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? BilledUntil { get; set; }

        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the related subscription
        /// advanced to a new billing period.
        /// </summary>
        [JsonProperty("billing_thresholds")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_thresholds")]
#endif
        public SubscriptionItemBillingThresholds BillingThresholds { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The end time of this subscription item's current billing period.
        /// </summary>
        [JsonProperty("current_period_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("current_period_end")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime CurrentPeriodEnd { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The start time of this subscription item's current billing period.
        /// </summary>
        [JsonProperty("current_period_start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("current_period_start")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime CurrentPeriodStart { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("deleted")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
#endif
        public bool? Deleted { get; set; }

        #region Expandable Discounts

        /// <summary>
        /// (IDs of the Discounts)
        /// The discounts applied to the subscription item. Subscription item discounts are applied
        /// before subscription discounts. Use <c>expand[]=discounts</c> to expand each discount.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public List<string> DiscountIds
        {
            get => this.InternalDiscounts?.Select((x) => x.Id).ToList();
            set => this.InternalDiscounts = SetExpandableArrayIds<Discount>(value);
        }

        /// <summary>
        /// (Expanded)
        /// The discounts applied to the subscription item. Subscription item discounts are applied
        /// before subscription discounts. Use <c>expand[]=discounts</c> to expand each discount.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public List<Discount> Discounts
        {
            get => this.InternalDiscounts?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalDiscounts = SetExpandableArrayObjects(value);
        }

        [JsonProperty("discounts", ItemConverterType = typeof(ExpandableFieldConverter<Discount>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discounts")]
#endif
        internal List<ExpandableField<Discount>> InternalDiscounts { get; set; }
        #endregion

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// You can now model subscriptions more flexibly using the <a
        /// href="https://api.stripe.com#prices">Prices API</a>. It replaces the Plans API and is
        /// backwards compatible to simplify your migration.
        ///
        /// Plans define the base price, currency, and billing cycle for recurring purchases of
        /// products. <a href="https://api.stripe.com#products">Products</a> help you track
        /// inventory or provisioning, and plans help you track pricing. Different physical goods or
        /// levels of service should be represented by products, and pricing options should be
        /// represented by plans. This approach lets you change prices without having to change your
        /// provisioning scheme.
        ///
        /// For example, you might have a single "gold" product that has plans for $10/month,
        /// $100/year, €9/month, and €90/year.
        ///
        /// Related guides: <a
        /// href="https://docs.stripe.com/billing/subscriptions/set-up-subscription">Set up a
        /// subscription</a> and more about <a
        /// href="https://docs.stripe.com/products-prices/overview">products and prices</a>.
        /// </summary>
        [JsonProperty("plan")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("plan")]
#endif
        public Plan Plan { get; set; }

        /// <summary>
        /// Prices define the unit cost, currency, and (optional) billing cycle for both recurring
        /// and one-time purchases of products. <a
        /// href="https://api.stripe.com#products">Products</a> help you track inventory or
        /// provisioning, and prices help you track payment terms. Different physical goods or
        /// levels of service should be represented by products, and pricing options should be
        /// represented by prices. This approach lets you change prices without having to change
        /// your provisioning scheme.
        ///
        /// For example, you might have a single "gold" product that has prices for $10/month,
        /// $100/year, and €9 once.
        ///
        /// Related guides: <a
        /// href="https://docs.stripe.com/billing/subscriptions/set-up-subscription">Set up a
        /// subscription</a>, <a href="https://docs.stripe.com/billing/invoices/create">create an
        /// invoice</a>, and more about <a
        /// href="https://docs.stripe.com/products-prices/overview">products and prices</a>.
        /// </summary>
        [JsonProperty("price")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price")]
#endif
        public Price Price { get; set; }

        /// <summary>
        /// The <a href="https://docs.stripe.com/subscriptions/quantities">quantity</a> of the plan
        /// to which the customer should be subscribed.
        /// </summary>
        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif
        public long Quantity { get; set; }

        /// <summary>
        /// The <c>subscription</c> this <c>subscription_item</c> belongs to.
        /// </summary>
        [JsonProperty("subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription")]
#endif
        public string Subscription { get; set; }

        /// <summary>
        /// The tax rates which apply to this <c>subscription_item</c>. When set, the
        /// <c>default_tax_rates</c> on the subscription do not apply to this
        /// <c>subscription_item</c>.
        /// </summary>
        [JsonProperty("tax_rates")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_rates")]
#endif
        public List<TaxRate> TaxRates { get; set; }

        /// <summary>
        /// Options that configure the trial on the subscription item.
        /// </summary>
        [JsonProperty("trial")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("trial")]
#endif
        public SubscriptionItemTrial Trial { get; set; }
    }
}
