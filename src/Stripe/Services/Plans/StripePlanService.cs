using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stripe
{
    public class StripePlanService : StripeService
    {
        public StripePlanService(string apiKey = null) : base(apiKey) { }

        public virtual StripePlan Create(StripePlanCreateOptions createOptions)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.Plans, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripePlan>.MapFromJson(response);
        }

        public virtual async Task<StripePlan> CreateAsync(StripePlanCreateOptions createOptions)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.Plans, false);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripePlan>.MapFromJson(response);
        }

        public virtual StripePlan Get(string planId)
        {
            var url = FormatGetUrl(planId);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripePlan>.MapFromJson(response);
        }

        public virtual async Task<StripePlan> GetAsync(string planId)
        {
            var url = FormatGetUrl(planId);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripePlan>.MapFromJson(response);
        }

        public virtual void Delete(string planId)
        {
            var url = FormatDeleteUrl(planId);

            Requestor.Delete(url, ApiKey);
        }

        public virtual async Task DeleteAsync(string planId)
        {
            var url = FormatDeleteUrl(planId);

            await Requestor.DeleteAsync(url, ApiKey);
        }

        public virtual StripePlan Update(string planId, StripePlanUpdateOptions updateOptions)
        {
            var url = FormatUpdateUrl(planId, updateOptions);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripePlan>.MapFromJson(response);
        }

        public virtual async Task<StripePlan> UpdateAsync(string planId, StripePlanUpdateOptions updateOptions)
        {
            var url = FormatUpdateUrl(planId, updateOptions);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripePlan>.MapFromJson(response);
        }

        public virtual IEnumerable<StripePlan> List(StripeListOptions listOptions = null)
        {
            var url = FormatListUrl(listOptions);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripePlan>.MapCollectionFromJson(response);
        }

        public virtual async Task<IEnumerable<StripePlan>> ListAsync(StripeListOptions listOptions = null)
        {
            var url = FormatListUrl(listOptions);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripePlan>.MapCollectionFromJson(response);
        }

        private string FormatListUrl(StripeListOptions listOptions)
        {
            var url = Urls.Plans;
            url = this.ApplyAllParameters(listOptions, url, true);
            return url;
        }

        private string FormatGetUrl(string planId)
        {
            var url = string.Format("{0}/{1}", Urls.Plans, planId);
            url = this.ApplyAllParameters(null, url, false);
            return url;
        }

        private static string FormatDeleteUrl(string planId)
        {
            var url = string.Format("{0}/{1}", Urls.Plans, planId);
            return url;
        }

        private string FormatUpdateUrl(string planId, StripePlanUpdateOptions updateOptions)
        {
            var url = string.Format("{0}/{1}", Urls.Plans, planId);
            url = this.ApplyAllParameters(updateOptions, url, false);
            return url;
        }
    }
}