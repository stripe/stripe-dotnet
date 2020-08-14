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
        /// Prices define the unit cost, currency, and (optional) billing cycle for both recurring
        /// and one-time purchases of products. <a
        /// href="https://stripe.com/docs/api#products">Products</a> help you track inventory or
        /// provisioning, and prices help you track payment terms. Different physical goods or
        /// levels of service should be represented by products, and pricing options should be
        /// represented by prices. This approach lets you change prices without having to change
        /// your provisioning scheme.
        ///
        /// For example, you might have a single "gold" product that has prices for $10/month,
        /// $100/year, and €9 once.
        ///
        /// Related guides: <a
        /// href="https://stripe.com/docs/billing/subscriptions/set-up-subscription">Set up a
        /// subscription</a>, <a href="https://stripe.com/docs/billing/invoices/create">create an
        /// invoice</a>, and more about <a
        /// href="https://stripe.com/docs/billing/prices-guide">products and prices</a>.
        /// </summary>
        [JsonProperty("price")]
        public Price Price { get; set; }

        /// <summary>
        /// The quantity of products being purchased.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The taxes applied to the line item.
        /// </summary>
        [JsonProperty("taxes")]
        public List<LineItemTax> Taxes { get; set; }
    }
}
