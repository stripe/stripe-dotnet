using System.Collections.Generic;

namespace Stripe
{
	public class StripePlanService
	{
		private string ApiKey { get; set; }

		public StripePlanService(string apiKey = null)
		{
			ApiKey = apiKey;
		}

		public virtual StripePlan Create(StripePlanCreateOptions createOptions)
		{
			var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.Plans);

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripePlan>.MapFromJson(response);
		}

		public virtual StripePlan Get(string planId)
		{
			var url = string.Format("{0}/{1}", Urls.Plans, planId);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripePlan>.MapFromJson(response);
		}

		public virtual void Delete(string planId)
		{
			var url = string.Format("{0}/{1}", Urls.Plans, planId);

			Requestor.Delete(url, ApiKey);
		}

		public virtual StripePlan Update(string planId, StripePlanUpdateOptions updateOptions)
		{
			var url = string.Format("{0}/{1}", Urls.Plans, planId);
			url = ParameterBuilder.ApplyAllParameters(updateOptions, url);

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripePlan>.MapFromJson(response);
		}

		public virtual IEnumerable<StripePlan> List(int limit = 10)
		{
			var url = Urls.Plans;
			url = ParameterBuilder.ApplyParameterToUrl(url, "limit", limit.ToString());

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripePlan>.MapCollectionFromJson(response);
		}
	}
}