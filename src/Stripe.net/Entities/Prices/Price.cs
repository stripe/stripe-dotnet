namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Price : StripeEntity<Price>, IHasId, IHasMetadata, IHasObject
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
        /// Whether the price can be used for new purchases.
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Describes how to compute the price per period. Either <c>per_unit</c> or <c>tiered</c>.
        /// <c>per_unit</c> indicates that the fixed amount (specified in <c>unit_amount</c> or
        /// <c>unit_amount_decimal</c>) will be charged per unit in <c>quantity</c> (for prices with
        /// <c>usage_type=licensed</c>), or per unit of total usage (for prices with
        /// <c>usage_type=metered</c>). <c>tiered</c> indicates that the unit pricing will be
        /// computed using a tiering strategy as defined using the <c>tiers</c> and
        /// <c>tiers_mode</c> attributes.
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
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// A lookup key used to retrieve prices dynamically from a static string.
        /// </summary>
        [JsonProperty("lookup_key")]
        public string LookupKey { get; set; }

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
        /// The ID of the product this price is associated with.
        /// </summary>
        [JsonIgnore]
        public string ProductId
        {
            get => this.InternalProduct?.Id;
            set => this.InternalProduct = SetExpandableFieldId(value, this.InternalProduct);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the product this price is associated with.
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
        /// The recurring components of a price such as <c>interval</c> and <c>usage_type</c>.
        /// </summary>
        [JsonProperty("recurring")]
        public PriceRecurring Recurring { get; set; }

        /// <summary>
        /// Each element represents a pricing tier. This parameter requires <c>billing_scheme</c> to
        /// be set to <c>tiered</c>. See also the documentation for <c>billing_scheme</c>.
        /// </summary>
        [JsonProperty("tiers")]
        public List<PriceTier> Tiers { get; set; }

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
        [JsonProperty("transform_quantity")]
        public PriceTransformQuantity TransformQuantity { get; set; }

        /// <summary>
        /// One of <c>one_time</c> or <c>recurring</c> depending on whether the price is for a
        /// one-time purchase or a recurring (subscription) purchase.
        /// One of: <c>one_time</c>, or <c>recurring</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The unit amount in %s to be charged, represented as a whole integer if possible.
        /// </summary>
        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }

        /// <summary>
        /// The unit amount in %s to be charged, represented as a decimal string with at most 12
        /// decimal places.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
