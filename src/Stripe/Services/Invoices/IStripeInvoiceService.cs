using System.Collections.Generic;

namespace Stripe
{
    public interface IStripeInvoiceService
    {
        StripeInvoice Get(string invoiceId);
        StripeInvoice Upcoming(string customerId);
        StripeInvoice Update(string invoiceId, StripeInvoiceUpdateOptions updateOptions);
        StripeInvoice Pay(string invoiceId);
        IEnumerable<StripeInvoice> List(int count = 10, int offset = 0, string customerId = null);
        StripeInvoice Create(string customerId);
    }
}