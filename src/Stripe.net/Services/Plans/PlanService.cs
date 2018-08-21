namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class PlanService : StripeService
    {
        public PlanService()
            : base(null)
        {
        }

        public PlanService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandProduct { get; set; }

        public virtual StripePlan Create(PlanCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            return Mapper<StripePlan>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, Urls.Plans, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripePlan Get(string planId, RequestOptions requestOptions = null)
        {
            return Mapper<StripePlan>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.Plans}/{WebUtility.UrlEncode(planId)}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripePlan Delete(string planId, RequestOptions requestOptions = null)
        {
            return Mapper<StripePlan>.MapFromJson(
                Requestor.Delete(
                    $"{Urls.Plans}/{WebUtility.UrlEncode(planId)}",
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripePlan Update(string planId, PlanUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            return Mapper<StripePlan>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{Urls.Plans}/{WebUtility.UrlEncode(planId)}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<StripePlan> List(PlanListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripePlan>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, Urls.Plans, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripePlan> CreateAsync(PlanCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripePlan>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, Urls.Plans, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripePlan> GetAsync(string planId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripePlan>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.Plans}/{WebUtility.UrlEncode(planId)}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripePlan> DeleteAsync(string planId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripePlan>.MapFromJson(
                await Requestor.DeleteAsync(
                    $"{Urls.Plans}/{WebUtility.UrlEncode(planId)}",
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripePlan> UpdateAsync(string planId, PlanUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripePlan>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{Urls.Plans}/{WebUtility.UrlEncode(planId)}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<StripePlan>> ListAsync(PlanListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripePlan>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, Urls.Plans, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
