using System.Collections.Generic;

namespace Stripe
{
	public class StripeApplicationFeeService
	{
		private string ApiKey { get; set; }

		public StripeApplicationFeeService(string apiKey = null)
		{
			ApiKey = apiKey;
		}

		public virtual StripeResponse<StripeApplicationFee> Get(string applicationFeeId)
		{
			var url = string.Format("{0}/{1}", Urls.ApplicationFees, applicationFeeId);
		    return url.GetResponse<StripeApplicationFee>(ApiKey);
		}

        public virtual StripeResponse<StripeApplicationFee> Refund(string applicationFeeId, int? refundAmount = null)
		{
			var url = string.Format("{0}/{1}/refund", Urls.ApplicationFees, applicationFeeId);
            if (refundAmount.HasValue)
            {
                url = ParameterBuilder.ApplyParameterToUrl(url, "amount", refundAmount.Value.ToString());
            }

            return url.PostResponse<StripeApplicationFee>(ApiKey);
		}

		public virtual StripeResponse<List<StripeApplicationFee>> List(StripeApplicationFeeListOptions listOptions)
		{
			var url = Urls.ApplicationFees;
		    if (listOptions != null)
		    {
		        url = ParameterBuilder.ApplyAllParameters(listOptions, url);
		    }

		    return url.GetResponseList<StripeApplicationFee>(ApiKey);
		}
	}
}