using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeInvoiceItemService
	{
		public virtual StripeInvoiceItem Create(StripeInvoiceItemCreateOptions createOptions)
		{
			var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.InvoiceItems);

			var response = Requestor.PostString(url);

			return Mapper<StripeInvoiceItem>.MapFromJson(response);
		}

		public virtual StripeInvoiceItem Get(string invoiceItemId)
		{
			var url = string.Format("{0}/{1}", Urls.InvoiceItems, invoiceItemId);

			var response = Requestor.GetString(url);

			return Mapper<StripeInvoiceItem>.MapFromJson(response);
		}

		public virtual StripeInvoiceItem Update(string invoiceItemId, StripeInvoiceItemUpdateOptions updateOptions)
		{
			var url = string.Format("{0}/{1}", Urls.InvoiceItems, invoiceItemId);
			url = ParameterBuilder.ApplyAllParameters(updateOptions, url);

			var response = Requestor.PostString(url);

			return Mapper<StripeInvoiceItem>.MapFromJson(response);
		}

		public virtual void Delete(string invoiceItemId)
		{
			var url = string.Format("{0}/{1}", Urls.InvoiceItems, invoiceItemId);

			Requestor.Delete(url);
		}

		public virtual IEnumerable<StripeInvoiceItem> List(int count = 10, int offset = 0, string customerId = null)
		{
			var url = Urls.InvoiceItems;
			url = ParameterBuilder.ApplyParameterToUrl(url, "count", count.ToString());
			url = ParameterBuilder.ApplyParameterToUrl(url, "offset", offset.ToString());

			if(!string.IsNullOrEmpty(customerId))
				url = ParameterBuilder.ApplyParameterToUrl(url, "customer", customerId);

			var response = Requestor.GetString(url);

			return Mapper<StripeInvoiceItem>.MapCollectionFromJson(response);
		}
	}
}