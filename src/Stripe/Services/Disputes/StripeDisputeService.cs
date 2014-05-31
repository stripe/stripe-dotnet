namespace Stripe
{
	public class StripeDisputeService
	{
		private string ApiKey { get; set; }

		public StripeDisputeService(string apiKey = null)
		{
			ApiKey = apiKey;
		}

		public bool ExpandCharge { get; set; }

		public virtual StripeDispute Update(string chargeId, string evidence = null)
		{
			var url = string.Format("{0}/dispute", chargeId);
			url = ApplyExpandableProperties(url);

			if (!string.IsNullOrEmpty(evidence))
				url = ParameterBuilder.ApplyParameterToUrl(url, "evidence", evidence);

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeDispute>.MapFromJson(response);
		}

		private string ApplyExpandableProperties(string url)
		{
			if (ExpandCharge)
				url += ParameterBuilder.ApplyParameterToUrl(url, "expand[]", "charge");

			return url;
		}
	}
}