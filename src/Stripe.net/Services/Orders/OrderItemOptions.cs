namespace Stripe
{
    using Stripe.Infrastructure;

    public class OrderItemOptions : INestedOptions
    {
        [FormProperty("amount")]
        public int? Amount { get; set; }

        [FormProperty("currency")]
        public string Currency { get; set; }

        [FormProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the SKU being ordered.
        /// </summary>
        [FormProperty("parent")]
        public string Parent { get; set; }

        /// <summary>
        /// The quantity of this order item. When type is sku, this is the number of instances of the SKU to be ordered.
        /// </summary>
        [FormProperty("quantity")]
        public int? Quantity { get; set; }

        [FormProperty("type")]
        public string Type { get; set; }
    }
}
