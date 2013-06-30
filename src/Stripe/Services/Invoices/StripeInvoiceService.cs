using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeInvoiceService
	{
		private string ApiKey { get; set; }

		public StripeInvoiceService(string apiKey = null)
		{
			ApiKey = apiKey;
		}

		public virtual StripeInvoice Get(string invoiceId)
		{
			var url = string.Format("{0}/{1}", Urls.Invoices, invoiceId);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeInvoice>.MapFromJson(response);
		}

		public virtual StripeInvoice Upcoming(string customerId)
		{
			var url = string.Format("{0}/{1}", Urls.Invoices, "upcoming");

			url = ParameterBuilder.ApplyParameterToUrl(url, "customer", customerId);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeInvoice>.MapFromJson(response);
		}

		public virtual StripeInvoice Update(string invoiceId, StripeInvoiceUpdateOptions updateOptions)
		{
			var url = string.Format("{0}/{1}", Urls.Invoices, invoiceId);
			url = ParameterBuilder.ApplyAllParameters(updateOptions, url);

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeInvoice>.MapFromJson(response);
		}

		public virtual StripeInvoice Pay(string invoiceId)
		{
			var url = string.Format("{0}/{1}/pay", Urls.Invoices, invoiceId);

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeInvoice>.MapFromJson(response);
		}

		public virtual IEnumerable<StripeInvoice> List(int count = 10, int offset = 0, string customerId = null)
		{
			var url = Urls.Invoices;
			url = ParameterBuilder.ApplyParameterToUrl(url, "count", count.ToString());
			url = ParameterBuilder.ApplyParameterToUrl(url, "offset", offset.ToString());

			if (!string.IsNullOrEmpty(customerId))
				url = ParameterBuilder.ApplyParameterToUrl(url, "customer", customerId);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeInvoice>.MapCollectionFromJson(response);
		}

		public virtual StripeInvoice Create(string customerId)
		{
			var url = Urls.Invoices;
			url = ParameterBuilder.ApplyParameterToUrl(url, "customer", customerId);

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeInvoice>.MapFromJson(response);
		}
	}
}