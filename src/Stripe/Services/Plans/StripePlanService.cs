using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stripe
{
    public class StripePlanService : StripeService
    {
        public StripePlanService(string apiKey = null) : base(apiKey) { }

        public virtual StripePlan Create(StripePlanCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripePlan>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(createOptions, Urls.Plans, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripePlan Get(string planId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripePlan>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, $"{Urls.Plans}/{planId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual void Delete(string planId, StripeRequestOptions requestOptions = null)
        {
            Requestor.Delete($"{Urls.Plans}/{planId}",
                SetupRequestOptions(requestOptions));
        }

        public virtual StripePlan Update(string planId, StripePlanUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripePlan>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(updateOptions, $"{Urls.Plans}/{planId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual IEnumerable<StripePlan> List(StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripePlan>.MapCollectionFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, Urls.Plans, true),
                SetupRequestOptions(requestOptions))
            );
        }

#if !PORTABLE
        public virtual async Task<StripePlan> CreateAsync(StripePlanCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripePlan>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, Urls.Plans, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<StripePlan> GetAsync(string planId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripePlan>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, $"{Urls.Plans}/{planId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async void DeleteAsync(string planId, StripeRequestOptions requestOptions = null)
        {
            await Requestor.DeleteAsync($"{Urls.Plans}/{planId}",
                SetupRequestOptions(requestOptions));
        }

        public virtual async Task<StripePlan> UpdateAsync(string planId, StripePlanUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripePlan>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(updateOptions, $"{Urls.Plans}/{planId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<IEnumerable<StripePlan>> ListAsync(StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripePlan>.MapCollectionFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, Urls.Plans, true),
                SetupRequestOptions(requestOptions))
            );
        }
#endif
    }
}
