using System.Collections.Generic;
using System.Threading.Tasks;
using Stripe.Services;

namespace Stripe
{
	public class StripeInvoiceItemService : BaseStripeService
	{
		public StripeInvoiceItemService(string apiKey = null) : base(apiKey)
		{
		}

		public virtual async Task<StripeInvoiceItem> Create(StripeInvoiceItemCreateOptions createOptions)
		{
			var data = ParameterBuilder.GenerateFormData(createOptions);

			var response = await Requestor.PostStringAsync(Urls.InvoiceItems, data, ApiKey);

			return Mapper<StripeInvoiceItem>.MapFromJson(response);
		}

		public virtual async Task<StripeInvoiceItem> Get(string invoiceItemId)
		{
			var url = string.Format("{0}/{1}", Urls.InvoiceItems, invoiceItemId);

			var response = await Requestor.GetStringAsync(url, ApiKey);

			return Mapper<StripeInvoiceItem>.MapFromJson(response);
		}

		public virtual async Task<StripeInvoiceItem> Update(string invoiceItemId, StripeInvoiceItemUpdateOptions updateOptions)
		{
			var url = string.Format("{0}/{1}", Urls.InvoiceItems, invoiceItemId);
			var data = ParameterBuilder.GenerateFormData(updateOptions);

			var response = await Requestor.PostStringAsync(url, data, ApiKey);

			return Mapper<StripeInvoiceItem>.MapFromJson(response);
		}

		public virtual async Task Delete(string invoiceItemId)
		{
			var url = string.Format("{0}/{1}", Urls.InvoiceItems, invoiceItemId);

			await Requestor.DeleteAsync(url, ApiKey);
		}

		public virtual async Task<List<StripeInvoiceItem>> List(int count = 10, int offset = 0, string customerId = null)
		{
		    var data = new List<KeyValuePair<string, string>>
		    {
		        new KeyValuePair<string, string>("count", count.ToString()),
		        new KeyValuePair<string, string>("offset", offset.ToString())
		    };
            
			if (!string.IsNullOrEmpty(customerId))
				data.Add(new KeyValuePair<string, string>("customer", customerId));

		    var url = ParameterBuilder.ApplyDataToUrl(Urls.InvoiceItems, data);


			var response = await Requestor.GetStringAsync(url, ApiKey);

			return Mapper<StripeInvoiceItem>.MapCollectionFromJson(response);
		}
	}
}