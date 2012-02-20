using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public interface IStripePlanService 
    {
        StripePlan Create(StripePlanCreateOptions createOptions);
        StripePlan Get(string planId);
        void Delete(string planId);
        IEnumerable<StripePlan> List(int count = 10, int offset = 0);
    }

    public class StripePlanService : IStripePlanService 
    {
		public StripePlan Create(StripePlanCreateOptions createOptions)
		{
			var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.Plans);

			var response = Requestor.PostString(url);

			return Mapper<StripePlan>.MapFromJson(response);
		}

		public StripePlan Get(string planId)
		{
			var url = string.Format("{0}/{1}", Urls.Plans, planId);

			var response = Requestor.GetString(url);

			return Mapper<StripePlan>.MapFromJson(response);
		}

		public void Delete(string planId)
		{
			var url = string.Format("{0}/{1}", Urls.Plans, planId);

			Requestor.Delete(url);
		}

		public IEnumerable<StripePlan> List(int count = 10, int offset = 0)
		{
			var url = Urls.Plans;
			url = ParameterBuilder.ApplyParameterToUrl(url, "count", count.ToString());
			url = ParameterBuilder.ApplyParameterToUrl(url, "offset", offset.ToString());

			var response = Requestor.GetString(url);

			return Mapper<StripePlan>.MapCollectionFromJson(response);
		}
    }
}