using System.Collections.Generic;
using System.Threading.Tasks;
using Stripe.Services;

namespace Stripe
{
	public class StripePlanService : BaseStripeService
	{
        public StripePlanService(string apiKey = null):base(apiKey)
		{
		}

		public virtual async Task<StripePlan> Create(StripePlanCreateOptions createOptions)
		{
			var data = ParameterBuilder.GenerateFormData(createOptions);

			var response = await Requestor.PostStringAsync(Urls.Plans, data, ApiKey);

			return Mapper<StripePlan>.MapFromJson(response);
		}

		public virtual async Task<StripePlan> Get(string planId)
		{
			var url = string.Format("{0}/{1}", Urls.Plans, planId);

			var response = await Requestor.GetStringAsync(url, ApiKey);

			return Mapper<StripePlan>.MapFromJson(response);
		}

		public virtual async Task Delete(string planId)
		{
			var url = string.Format("{0}/{1}", Urls.Plans, planId);

			await Requestor.DeleteAsync(url, ApiKey);
		}

		public virtual async Task<StripePlan> Update(string planId, StripePlanUpdateOptions updateOptions)
		{
			var url = string.Format("{0}/{1}", Urls.Plans, planId);
			var data = ParameterBuilder.GenerateFormData(updateOptions);

			var response = await Requestor.PostStringAsync(url, data, ApiKey);

			return Mapper<StripePlan>.MapFromJson(response);
		}

		public virtual async Task<List<StripePlan>> List(int count = 10, int offset = 0)
		{
		    var url = ParameterBuilder.ApplyDataToUrl(Urls.Plans, new List<KeyValuePair<string, string>>
		    {
		        new KeyValuePair<string, string>("count", count.ToString()),
		        new KeyValuePair<string, string>("offset", offset.ToString())
		    });

			var response = await Requestor.GetStringAsync(url, ApiKey);

			return Mapper<StripePlan>.MapCollectionFromJson(response);
		}
	}
}