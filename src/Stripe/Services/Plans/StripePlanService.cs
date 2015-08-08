using System.Collections.Generic;

namespace Stripe
{
    public class StripePlanService : StripeService
    {
        public StripePlanService(string apiKey = null) : base(apiKey) { }

        public virtual StripePlan Create(StripePlanCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = this.ApplyAllParameters(createOptions, Urls.Plans, false);

            var response = Requestor.PostString(url, requestOptions);

            return Mapper<StripePlan>.MapFromJson(response);
        }

        public virtual StripePlan Get(string planId, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/{1}", Urls.Plans, planId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripePlan>.MapFromJson(response);
        }

        public virtual void Delete(string planId, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/{1}", Urls.Plans, planId);

            Requestor.Delete(url, requestOptions);
        }

        public virtual StripePlan Update(string planId, StripePlanUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/{1}", Urls.Plans, planId);
            url = this.ApplyAllParameters(updateOptions, url, false);

            var response = Requestor.PostString(url, requestOptions);

            return Mapper<StripePlan>.MapFromJson(response);
        }

        public virtual IEnumerable<StripePlan> List(StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = Urls.Plans;
            url = this.ApplyAllParameters(listOptions, url, true);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripePlan>.MapCollectionFromJson(response);
        }
    }
}