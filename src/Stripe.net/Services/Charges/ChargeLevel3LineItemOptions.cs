namespace Stripe
{
    using Stripe.Infrastructure;

    public class ChargeLevel3LineItemOptions : INestedOptions
    {
        [FormProperty("discount_amount")]
        public int? DiscountAmount { get; set; }

        [FormProperty("product_code")]
        public string ProductCode { get; set; }

        [FormProperty("product_description")]
        public string ProductDescription { get; set; }

        [FormProperty("quantity")]
        public int? Quantity { get; set; }

        [FormProperty("tax_amount")]
        public int? TaxAmount { get; set; }

        [FormProperty("unit_cost")]
        public int? UnitCost { get; set; }
    }
}
