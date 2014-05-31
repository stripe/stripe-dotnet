using System.Collections.Generic;

namespace Stripe
{
	public class StripeApplicationFeeService : StripeService
	{
		public StripeApplicationFeeService(string apiKey = null)
			: base(apiKey) { }

		public bool ExpandCustomer { get; set; }
		public bool ExpandBalanceTransaction { get; set; }
		public bool ExpandCharge { get; set; }

		public virtual StripeApplicationFee Get(string applicationFeeId)
		{
			var url = string.Format("{0}/{1}", Urls.ApplicationFees, applicationFeeId);
			url = ApplyExpandableProperties(url);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeApplicationFee>.MapFromJson(response);
		}

		public virtual StripeApplicationFee Refund(string applicationFeeId, int? refundAmount = null)
		{
			var url = string.Format("{0}/{1}/refund", Urls.ApplicationFees, applicationFeeId);
			url = ApplyExpandableProperties(url);

			if (refundAmount.HasValue)
				url = ParameterBuilder.ApplyParameterToUrl(url, "amount", refundAmount.Value.ToString());

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeApplicationFee>.MapFromJson(response);
		}

		public virtual IEnumerable<StripeApplicationFee> List(StripeApplicationFeeListOptions listOptions)
		{
			var url = Urls.ApplicationFees;

			if (listOptions != null)
				url = this.ApplyAllParameters(listOptions, url);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeApplicationFee>.MapCollectionFromJson(response);
		}

		private string ApplyExpandableProperties(string url)
		{
			if (ExpandCustomer)
				url += ParameterBuilder.ApplyParameterToUrl(url, "expand[]", "customer");
			if (ExpandBalanceTransaction)
				url += ParameterBuilder.ApplyParameterToUrl(url, "expand[]", "balance_transaction");
			if (ExpandCharge)
				url += ParameterBuilder.ApplyParameterToUrl(url, "expand[]", "charge");

			return url;
		}
	}
}