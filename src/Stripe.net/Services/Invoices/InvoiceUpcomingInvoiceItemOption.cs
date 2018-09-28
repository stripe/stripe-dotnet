namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class InvoiceUpcomingInvoiceItemOption : INestedOptions
    {
        [FormProperty("amount")]
        public int? Amount { get; set; }

        [FormProperty("currency")]
        public string Currency { get; set; }

        [FormProperty("description")]
        public string Description { get; set; }

        [FormProperty("discountable")]
        public bool? Discountable { get; set; }

        [FormProperty("invoiceitem")]
        public string InvoiceItemId { get; set; }

        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
