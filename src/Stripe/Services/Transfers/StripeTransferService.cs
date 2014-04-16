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

		public virtual IEnumerable<StripeTransfer> List(StripeTransferListOptions options = null)
		{
			var url = Urls.Transfers;
			if (options != null)
			{
				url = ParameterBuilder.ApplyAllParameters(options, url);
			}

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeTransfer>.MapCollectionFromJson(response);
		}
	}
}