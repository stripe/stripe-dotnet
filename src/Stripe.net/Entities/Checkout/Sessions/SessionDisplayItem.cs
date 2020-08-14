namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionDisplayItem : StripeEntity<SessionDisplayItem>
    {
        /// <summary>
        /// Amount for the display item.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("custom")]
        public SessionDisplayItemCustom Custom { get; set; }

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
        /// href="https://stripe.com/docs/billing/prices-guide">products and prices</a>.
        /// </summary>
        [JsonProperty("plan")]
        public Plan Plan { get; set; }

        /// <summary>
        /// Quantity of the display item being purchased.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// Stores representations of <a
        /// href="http://en.wikipedia.org/wiki/Stock_keeping_unit">stock keeping units</a>. SKUs
        /// describe specific product variations, taking into account any combination of:
        /// attributes, currency, and cost. For example, a product may be a T-shirt, whereas a
        /// specific SKU represents the <c>size: large</c>, <c>color: red</c> version of that shirt.
        ///
        /// Can also be used to manage inventory.
        ///
        /// Related guide: <a href="https://stripe.com/docs/orders">Tax, Shipping, and
        /// Inventory</a>.
        /// </summary>
        [JsonProperty("sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// The type of display item. One of <c>custom</c>, <c>plan</c> or <c>sku</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
