namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class OrderItem : StripeEntity<OrderItem>, IHasObject
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// A positive integer in the smallest currency unit (that is, 100 cents for $1.00, or 1 for ¥1, Japanese Yen being a 0-decimal currency) representing the total amount for the line item.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Three-letter ISO currency code, in lowercase. Must be a supported currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Description of the line item, meant to be displayable to the user (e.g., "Express shipping").
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        #region Expandable Parent

        /// <summary>
        /// ID of the parent associated with this order item.
        /// </summary>
        [JsonIgnore]
        public string ParentId => this.InternalParent.Id;

        [JsonIgnore]
        public Sku Parent => this.InternalParent.ExpandedObject;

        [JsonProperty("parent")]
        [JsonConverter(typeof(ExpandableFieldConverter<Sku>))]
        internal ExpandableField<Sku> InternalParent { get; set; }
        #endregion

        /// <summary>
        /// A positive integer representing the number of instances of parent that are included in this order item. Applicable/present only if type is sku.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The type of line item. One of sku, tax, shipping, or discount.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
