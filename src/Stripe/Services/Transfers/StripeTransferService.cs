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

		public virtual StripeResponse<StripeTransfer> Create(StripeTransferCreateOptions createOptions)
		{
			var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.Transfers);

		    return url.PostResponse<StripeTransfer>(ApiKey);
		}

	    public virtual StripeResponse<StripeTransfer> Get(string transferId)
	    {
	        var url = string.Format("{0}/{1}", Urls.Transfers, transferId);

	        return url.GetResponse<StripeTransfer>(ApiKey);
	    }

	    public virtual StripeResponse<StripeTransfer> Cancel(string transferId)
		{
			var url = string.Format("{0}/{1}/cancel", Urls.Transfers, transferId);

            return url.PostResponse<StripeTransfer>(ApiKey);
		}

		public virtual StripeResponse<List<StripeTransfer>> List(StripeTransferListOptions listOptions = null)
		{
			var url = Urls.Transfers;
		    if (listOptions != null)
		    {
		        url = ParameterBuilder.ApplyAllParameters(listOptions, url);
		    }

		    return url.GetResponseList<StripeTransfer>(ApiKey);
		}
	}
}