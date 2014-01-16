using System.Collections.Generic;
using System.Threading.Tasks;
using Stripe.Services;

namespace Stripe
{
    public class StripeInvoiceService : BaseStripeService
    {
        public StripeInvoiceService(string apiKey = null)
            : base(apiKey)
        {
        }

        public virtual async Task<StripeInvoice> Get(string invoiceId)
        {
            var url = string.Format("{0}/{1}", Urls.Invoices, invoiceId);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeInvoice>.MapFromJson(response);
        }

        public virtual async Task<StripeInvoice> Upcoming(string customerId)
        {
            var url = string.Format("{0}/{1}", Urls.Invoices, "upcoming");
            url = ParameterBuilder.ApplyDataToUrl(url,
                new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("customer", customerId) });

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeInvoice>.MapFromJson(response);
        }

        public virtual async Task<StripeInvoice> Update(string invoiceId, StripeInvoiceUpdateOptions updateOptions)
        {
            var url = string.Format("{0}/{1}", Urls.Invoices, invoiceId);
            var data = ParameterBuilder.GenerateFormData(updateOptions);

            var response = await Requestor.PostStringAsync(url, data, ApiKey);

            return Mapper<StripeInvoice>.MapFromJson(response);
        }

        public virtual async Task<StripeInvoice> Pay(string invoiceId)
        {
            var url = string.Format("{0}/{1}/pay", Urls.Invoices, invoiceId);
            var data = new List<KeyValuePair<string, string>>();
            var response = await Requestor.PostStringAsync(url, data, ApiKey);

            return Mapper<StripeInvoice>.MapFromJson(response);
        }

        public virtual async Task<IEnumerable<StripeInvoice>> List(int count = 10, int offset = 0, string customerId = null)
        {

            var data = new List<KeyValuePair<string, string>>
		    {
		        new KeyValuePair<string, string>("count", count.ToString()),
		        new KeyValuePair<string, string>("offset", offset.ToString())
		    };

            if (!string.IsNullOrEmpty(customerId))
                data.Add(new KeyValuePair<string, string>("customer", customerId));

            var url = ParameterBuilder.ApplyDataToUrl(Urls.Invoices, data);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeInvoice>.MapCollectionFromJson(response);
        }

        public virtual async Task<StripeInvoice> Create(string customerId)
        {
            var url = Urls.Invoices;
            var data = new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("customer", customerId) };

            var response = await Requestor.PostStringAsync(Urls.Invoices, data, ApiKey);

            return Mapper<StripeInvoice>.MapFromJson(response);
        }
    }
}