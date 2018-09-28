namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class InvoiceUpdateOptions : BaseOptions, ISupportMetadata
    {
        [FormProperty("application_fee")]
        public int? ApplicationFee { get; set; }

        [FormProperty("closed")]
        public bool? Closed { get; set; }

        [FormProperty("description")]
        public string Description { get; set; }

        [FormProperty("forgiven")]
        public bool? Forgiven { get; set; }

        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Boolean representing whether an invoice is paid or not. To mark invoice as paid, pass true. Only applies to invoices where billing=send_invoice.
        /// </summary>
        [FormProperty("paid")]
        public bool? Paid { get; set; }

        [FormProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [FormProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }
    }
}
