using System.Collections.Generic;

namespace Stripe
{
	public class StripeTransferService
	{
		private string ApiKey { get; set; }

		public StripeTransferService(string apiKey = null)
		{
			ApiKey = apiKey;
		}

		public virtual StripeTransfer Create(StripeTransferCreateOptions createOptions)
		{
			var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.Transfers);

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeTransfer>.MapFromJson(response);
		}

		public virtual StripeTransfer Get(string transferId)
		{
			var url = string.Format("{0}/{1}", Urls.Transfers, transferId);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeTransfer>.MapFromJson(response);
		}

		public virtual StripeTransfer Cancel(string transferId)
		{
			var url = string.Format("{0}/{1}/cancel", Urls.Transfers, transferId);

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeTransfer>.MapFromJson(response);
		}

		public virtual IEnumerable<StripeTransfer> List(int limit = 10, string recipientId = null, string status = null)
		{
			var url = Urls.Transfers;
			url = ParameterBuilder.ApplyParameterToUrl(url, "limit", limit.ToString());

			if (!string.IsNullOrEmpty(recipientId))
				url = ParameterBuilder.ApplyParameterToUrl(url, "recipient", recipientId);

			if (!string.IsNullOrEmpty(status))
				url = ParameterBuilder.ApplyParameterToUrl(url, "status", status);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeTransfer>.MapCollectionFromJson(response);
		}
	}
}