namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class InventoryOptions : INestedOptions
    {
        [FormProperty("quantity")]
        public int? Quantity { get; set; }

        [FormProperty("type")]
        public string Type { get; set; }

        [FormProperty("value")]
        public string Value { get; set; }
    }
}
