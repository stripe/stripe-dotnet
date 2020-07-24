namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class LineItem : StripeEntity<LineItem>, IHasId, IHasObject
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
        /// Total before any discounts or taxes is applied.
        /// </summary>
        [JsonProperty("amount_subtotal")]
        public long? AmountSubtotal { get; set; }

        /// <summary>
        /// Total after discounts and taxes.
        /// </summary>
        [JsonProperty("amount_total")]
        public long? AmountTotal { get; set; }

        /// <summary>
        /// Three-letter ISO currency code, in lowercase. Must be a supported currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// Defaults to product name.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The discounts applied to the line item.
        /// </summary>
        [JsonProperty("discounts")]
        public List<LineItemDiscount> Discounts { get; set; }

        /// <summary>
        /// The price used to generate the line item.
        /// </summary>
        [JsonProperty("price")]
        public Price Price { get; set; }

        /// <summary>
        /// Quantity associated with the line item.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// Details of all taxes applied to this line item.
        /// </summary>
        [JsonProperty("taxes")]
        public List<LineItemTax> Taxes { get; set; }
    }
}
