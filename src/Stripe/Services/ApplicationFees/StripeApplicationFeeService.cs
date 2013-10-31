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

		public virtual IEnumerable<StripeApplicationFee> Get(string chargeId)
		{
            var url = string.Format("{0}?charge={1}", Urls.ApplicationFees, chargeId);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeApplicationFee>.MapCollectionFromJson(response);
		}

        public virtual StripeApplicationFee Refund(string applicationFeeId, int refundAmountInCents)
        {
            var url = string.Format("{0}/{1}/refund", Urls.ApplicationFees, applicationFeeId);

            url = ParameterBuilder.ApplyParameterToUrl(url, "amount", refundAmountInCents.ToString());

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeApplicationFee>.MapFromJson(response);
        }
    }
}