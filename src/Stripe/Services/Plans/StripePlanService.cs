using System.Collections.Generic;
using System.Linq;

namespace Stripe
{
    public class StripePlanService
    {
        public StripePlan Create(StripePlanCreateOptions createOptions)
        {
            var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.Plans);
            
            var response = Requestor.PostString(url);

            return PopulateStripePlan(response);
        }

        public StripePlan Get(string planId)
        {
            var url = string.Format("{0}/{1}", Urls.Plans, planId);

            var response = Requestor.GetString(url);

            return PopulateStripePlan(response);
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

            var json = Mapper<StripePlan>.MapCollectionToObjectList(response);

            return json.Select(PopulateStripePlan);
        }

        private StripePlan PopulateStripePlan(string json)
        {
            return Mapper<StripePlan>.MapFromJson(json);
        }
    }
}