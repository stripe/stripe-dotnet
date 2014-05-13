using System.Collections.Generic;

namespace Stripe
{
	public class StripeInvoiceService
	{
		private string ApiKey { get; set; }

		public StripeInvoiceService(string apiKey = null)
		{
			ApiKey = apiKey;
		}

		public virtual StripeResponse<StripeInvoice> Get(string invoiceId)
		{
			var url = string.Format("{0}/{1}", Urls.Invoices, invoiceId);
            return url.GetResponse<StripeInvoice>(ApiKey);
		}

        public virtual StripeResponse<StripeInvoice> Upcoming(string customerId)
		{
			var url = string.Format("{0}/{1}", Urls.Invoices, "upcoming");
            url = ParameterBuilder.ApplyParameterToUrl(url, "customer", customerId);

            return url.GetResponse<StripeInvoice>(ApiKey);
		}

        public virtual StripeResponse<StripeInvoice> Update(string invoiceId, StripeInvoiceUpdateOptions updateOptions)
		{
			var url = string.Format("{0}/{1}", Urls.Invoices, invoiceId);
			url = ParameterBuilder.ApplyAllParameters(updateOptions, url);

            return url.PostResponse<StripeInvoice>(ApiKey);
		}

        public virtual StripeResponse<StripeInvoice> Pay(string invoiceId)
		{
			var url = string.Format("{0}/{1}/pay", Urls.Invoices, invoiceId);

            return url.PostResponse<StripeInvoice>(ApiKey);
		}

		public virtual StripeResponse<List<StripeInvoice>> List(StripeInvoiceListOptions listOptions = null)
		{
			var url = Urls.Invoices;

			if (listOptions != null)
				url = ParameterBuilder.ApplyAllParameters(listOptions, url);

		    return url.GetResponseList<StripeInvoice>(ApiKey);
		}

        public virtual StripeResponse<StripeInvoice> Create(string customerId)
		{
			var url = Urls.Invoices;
			url = ParameterBuilder.ApplyParameterToUrl(url, "customer", customerId);

            return url.PostResponse<StripeInvoice>(ApiKey);
		}
	}
}