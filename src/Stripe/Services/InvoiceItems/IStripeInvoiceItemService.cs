using System.Collections.Generic;

namespace Stripe
{
    public interface IStripeInvoiceItemService
    {
        StripeInvoiceItem Create(StripeInvoiceItemCreateOptions createOptions);
        StripeInvoiceItem Get(string invoiceItemId);
        StripeInvoiceItem Update(string invoiceItemId, StripeInvoiceItemUpdateOptions updateOptions);
        void Delete(string invoiceItemId);
        IEnumerable<StripeInvoiceItem> List(int count = 10, int offset = 0, string customerId = null);
    }
}