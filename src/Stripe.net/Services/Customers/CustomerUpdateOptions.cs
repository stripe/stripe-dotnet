namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class CustomerUpdateOptions : BaseOptions, ISupportMetadata
    {
        [FormProperty("account_balance")]
        public int? AccountBalance { get; set; }

        [FormProperty("source")]
        public string SourceToken { get; set; }

        [FormProperty("source")]
        public CardCreateNestedOptions SourceCard { get; set; }

        [FormProperty("coupon")]
        public string Coupon { get; set; }

        [FormProperty("default_source")]
        public string DefaultSource { get; set; }

        [FormProperty("description")]
        public string Description { get; set; }

        [FormProperty("email")]
        public string Email { get; set; }

        [FormProperty("invoice_prefix")]
        public string InvoicePrefix { get; set; }

        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [FormProperty("shipping")]
        public ShippingOptions Shipping { get; set; }

        [FormProperty("tax_info")]
        public CustomerTaxInfoOptions TaxInfo { get; set; }
    }
}
