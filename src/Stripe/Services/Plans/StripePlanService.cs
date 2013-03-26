using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Stripe.Infrastructure;

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

		public virtual IEnumerable<StripePlan> List(int count = 10, int offset = 0)
		{
			var url = Urls.Plans;
			url = ParameterBuilder.ApplyParameterToUrl(url, "count", count.ToString());
			url = ParameterBuilder.ApplyParameterToUrl(url, "offset", offset.ToString());

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripePlan>.MapCollectionFromJson(response);
		}
	}
}