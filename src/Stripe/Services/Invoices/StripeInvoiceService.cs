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

        public virtual StripeInvoice Upcoming(string customerId, string subscriptionId)
        {
            var url = string.Format("{0}/{1}", Urls.Invoices, "upcoming");

            url = ParameterBuilder.ApplyParameterToUrl(url, "customer", customerId);
            url = ParameterBuilder.ApplyParameterToUrl(url, "subscription", subscriptionId);

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

		public virtual IEnumerable<StripeInvoice> List(StripeInvoiceListOptions listOptions = null)
		{
			var url = Urls.Invoices;

			if (listOptions != null)
				url = ParameterBuilder.ApplyAllParameters(listOptions, url);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeInvoice>.MapCollectionFromJson(response);
		}

		public virtual StripeInvoice Create(string customerId, int? fee = null)
		{
			var url = Urls.Invoices;
			url = ParameterBuilder.ApplyParameterToUrl(url, "customer", customerId);
            
            if(fee.HasValue)
			    url = ParameterBuilder.ApplyParameterToUrl(url, "application_fee", fee.Value.ToString());

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeInvoice>.MapFromJson(response);
		}

        public virtual StripeInvoice Create(string customerId, string subscriptionId, int? fee = null)
        {
            var url = Urls.Invoices;
            url = ParameterBuilder.ApplyParameterToUrl(url, "customer", customerId);
            url = ParameterBuilder.ApplyParameterToUrl(url, "subscription", subscriptionId);

            if (fee.HasValue)
                url = ParameterBuilder.ApplyParameterToUrl(url, "application_fee", fee.Value.ToString());

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeInvoice>.MapFromJson(response);
        }
	}
}