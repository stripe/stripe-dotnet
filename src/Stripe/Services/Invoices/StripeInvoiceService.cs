using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Stripe.Infrastructure;

namespace Stripe
{
    public interface IStripeInvoiceService 
    {
        StripeInvoice Get(string invoiceId);
        StripeInvoice Upcoming(string customerId);
        IEnumerable<StripeInvoice> List(int count = 10, int offset = 0, string customerId = null);
    }

    public class StripeInvoiceService : IStripeInvoiceService {
        public StripeInvoice Get(string invoiceId)
        {
            var url = string.Format("{0}/{1}", Urls.Invoices, invoiceId);

            var response = Requestor.GetString(url);

            return Mapper<StripeInvoice>.MapFromJson(response);
        }

        public StripeInvoice Upcoming(string customerId)
        {
            var url = string.Format("{0}/{1}", Urls.Invoices, "upcoming");

            url = ParameterBuilder.ApplyParameterToUrl(url, "customer", customerId);

            var response = Requestor.GetString(url);

            return Mapper<StripeInvoice>.MapFromJson(response);
        }

        public IEnumerable<StripeInvoice> List(int count = 10, int offset = 0, string customerId = null)
        {
            var url = Urls.Invoices;
            url = ParameterBuilder.ApplyParameterToUrl(url, "count", count.ToString());
            url = ParameterBuilder.ApplyParameterToUrl(url, "offset", offset.ToString());

            if(!string.IsNullOrEmpty(customerId))
                url = ParameterBuilder.ApplyParameterToUrl(url, "customer", customerId);

            var response = Requestor.GetString(url);

            return Mapper<StripeInvoice>.MapCollectionFromJson(response);
        }
    }
}