using Newtonsoft.Json;

namespace Stripe
{
    public class StripeOrderItemBase : StripeEntity
    {
        /// <summary>
        /// Gets or sets a positive integer in the smallest currency unit (that is, 100 cents for $1.00, or 1 for ¥1, Japanese Yen being a 0-decimal currency) representing the total amount for the line item.
        /// Note: This is not nullable on the order item object, but is nullable in the order creation.
        /// </summary>
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        /// <summary>
        /// Gets or sets description of the line item, meant to be displayable to the user (e.g., "Express shipping").
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the ID of the associated object for this line item. Expandable if not null (e.g., expandable to a SKU).
        /// Expandable
        /// </summary>
        ////TODO: expand
        [JsonProperty("parent")]
        public string ParentId { get; set; }

        /// <summary>
        /// Gets or sets a positive integer representing the number of instances of parent that are included in this order item. Applicable/present only if Type is sku.
        /// </summary>
        [JsonProperty("quantity")]
        public uint? Quantity { get; set; }

        /// <summary>
        /// Gets or sets the Type of line item. One of sku, tax, shipping, or discount
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
