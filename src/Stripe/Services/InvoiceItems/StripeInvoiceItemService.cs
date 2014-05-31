using System.Collections.Generic;

namespace Stripe
{
	public class StripeInvoiceItemService : StripeService
	{
		public StripeInvoiceItemService(string apiKey = null)
			: base(apiKey) { }

		public bool ExpandCustomer { get; set; }

		public virtual StripeInvoiceItem Create(StripeInvoiceItemCreateOptions createOptions)
		{
			var url = this.ApplyAllParameters(createOptions, Urls.InvoiceItems);

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeInvoiceItem>.MapFromJson(response);
		}

		public virtual StripeInvoiceItem Get(string invoiceItemId)
		{
			var url = string.Format("{0}/{1}", Urls.InvoiceItems, invoiceItemId);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeInvoiceItem>.MapFromJson(response);
		}

		public virtual StripeInvoiceItem Update(string invoiceItemId, StripeInvoiceItemUpdateOptions updateOptions)
		{
			var url = string.Format("{0}/{1}", Urls.InvoiceItems, invoiceItemId);
			url = this.ApplyAllParameters(updateOptions, url);

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeInvoiceItem>.MapFromJson(response);
		}

		public virtual void Delete(string invoiceItemId)
		{
			var url = string.Format("{0}/{1}", Urls.InvoiceItems, invoiceItemId);

			Requestor.Delete(url, ApiKey);
		}

		public virtual IEnumerable<StripeInvoiceItem> List(StripeInvoiceItemListOptions listOptions = null)
		{
			var url = Urls.InvoiceItems;

			if (listOptions != null)
				url = this.ApplyAllParameters(listOptions, url);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeInvoiceItem>.MapCollectionFromJson(response);
		}

		private string ApplyExpandableProperties(string url)
		{
			if (ExpandCustomer)
				url += ParameterBuilder.ApplyParameterToUrl(url, "expand[]", "customer");

			return url;
		}
	}
}