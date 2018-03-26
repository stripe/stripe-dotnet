using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;
using System.Net;

namespace Stripe
{
    public class StripePlanService : StripeService
    {
        public StripePlanService() : base(null) { }
        public StripePlanService(string apiKey) : base(apiKey) { }

        public bool ExpandProduct { get; set; }


        //Sync
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
                Requestor.GetString(this.ApplyAllParameters(null, $"{Urls.Plans}/{WebUtility.UrlEncode(planId)}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeDeleted Delete(string planId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeDeleted>.MapFromJson(
                Requestor.Delete($"{Urls.Plans}/{WebUtility.UrlEncode(planId)}",
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripePlan Update(string planId, StripePlanUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripePlan>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(updateOptions, $"{Urls.Plans}/{WebUtility.UrlEncode(planId)}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeList<StripePlan> List(StripePlanListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripePlan>>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, Urls.Plans, true),
                SetupRequestOptions(requestOptions))
            );
        }



        //Async
        public virtual async Task<StripePlan> CreateAsync(StripePlanCreateOptions createOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripePlan>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, Urls.Plans, false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripePlan> GetAsync(string planId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripePlan>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, $"{Urls.Plans}/{WebUtility.UrlEncode(planId)}", false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeDeleted> DeleteAsync(string planId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeDeleted>.MapFromJson(
                await Requestor.DeleteAsync($"{Urls.Plans}/{WebUtility.UrlEncode(planId)}",
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripePlan> UpdateAsync(string planId, StripePlanUpdateOptions updateOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripePlan>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(updateOptions, $"{Urls.Plans}/{WebUtility.UrlEncode(planId)}", false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeList<StripePlan>> ListAsync(StripePlanListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripePlan>>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, Urls.Plans, true),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }
    }
}
