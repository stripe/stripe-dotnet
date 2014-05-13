using System.Collections.Generic;

namespace Stripe
{
	public class StripeInvoiceItemService
	{
		private string ApiKey { get; set; }

		public StripeInvoiceItemService(string apiKey = null)
		{
			ApiKey = apiKey;
		}

		public virtual StripeResponse<StripeInvoiceItem> Create(StripeInvoiceItemCreateOptions createOptions)
		{
			var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.InvoiceItems);
		    return url.PostResponse<StripeInvoiceItem>(ApiKey);
		}

        public virtual StripeResponse<StripeInvoiceItem> Get(string invoiceItemId)
		{
			var url = string.Format("{0}/{1}", Urls.InvoiceItems, invoiceItemId);
            return url.GetResponse<StripeInvoiceItem>(ApiKey);
		}

        public virtual StripeResponse<StripeInvoiceItem> Update(string invoiceItemId, StripeInvoiceItemUpdateOptions updateOptions)
		{
			var url = string.Format("{0}/{1}", Urls.InvoiceItems, invoiceItemId);
			url = ParameterBuilder.ApplyAllParameters(updateOptions, url);

            return url.PostResponse<StripeInvoiceItem>(ApiKey);
		}

		public virtual void Delete(string invoiceItemId)
		{
			var url = string.Format("{0}/{1}", Urls.InvoiceItems, invoiceItemId);
		    url.DeleteResponse<StripeInvoiceItem>(ApiKey);
		}

		public virtual StripeResponse<List<StripeInvoiceItem>> List(StripeInvoiceItemListOptions listOptions = null)
		{
			var url = Urls.InvoiceItems;
		    if (listOptions != null)
		    {
		        url = ParameterBuilder.ApplyAllParameters(listOptions, url);
		    }

		    return url.GetResponseList<StripeInvoiceItem>(ApiKey);
		}
	}
}