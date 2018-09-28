namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class PaymentIntentConfirmOptions : BaseOptions
    {
        [FormProperty("invoice")]
        public string Invoice { get; set; }

        [FormProperty("invoice_charge_reason")]
        public string InvoiceChargeReason { get; set; }

        [FormProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        [FormProperty("return_url")]
        public string ReturnUrl { get; set; }

        [FormProperty("save_source_to_customer")]
        public bool? SaveSourceToCustomer { get; set; }

        [FormProperty("source")]
        public string SourceId { get; set; }
    }
}
