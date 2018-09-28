namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class InvoiceItemUpdateOptions : BaseOptions, ISupportMetadata
    {
        [FormProperty("amount")]
        public int? Amount { get; set; }

        [FormProperty("description")]
        public string Description { get; set; }

        [FormProperty("discountable")]
        public bool? Discountable { get; set; }

        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [FormProperty("quantity")]
        public int? Quantity { get; set; }

        [FormProperty("unit_amount")]
        public int? UnitAmount { get; set; }
    }
}
