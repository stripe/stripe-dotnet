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

		public virtual StripeResponse<StripePlan> Create(StripePlanCreateOptions createOptions)
		{
			var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.Plans);
		    return url.PostResponse<StripePlan>(ApiKey);
		}

        public virtual StripeResponse<StripePlan> Get(string planId)
		{
			var url = string.Format("{0}/{1}", Urls.Plans, planId);

            return url.GetResponse<StripePlan>(ApiKey);
		}

		public virtual void Delete(string planId)
		{
			var url = string.Format("{0}/{1}", Urls.Plans, planId);

		    url.DeleteResponse<StripePlan>(ApiKey);
		}

        public virtual StripeResponse<StripePlan> Update(string planId, StripePlanUpdateOptions updateOptions)
		{
			var url = string.Format("{0}/{1}", Urls.Plans, planId);
			url = ParameterBuilder.ApplyAllParameters(updateOptions, url);
            return url.PostResponse<StripePlan>(ApiKey);
		}

        public virtual StripeResponse<List<StripePlan>> List(StripeListOptions listOptions = null)
		{
			var url = Urls.Plans;

            if (listOptions != null)
            {
                url = ParameterBuilder.ApplyAllParameters(listOptions, url);
            }

            return url.GetResponseList<StripePlan>(ApiKey);
		}
	}
}