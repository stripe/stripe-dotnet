namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class PlanService : StripeService,
        ICreatable<Plan, PlanCreateOptions>,
        IDeletable<Plan>,
        IListable<Plan, PlanListOptions>,
        IRetrievable<Plan>,
        IUpdatable<Plan, PlanUpdateOptions>
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

        public virtual Plan Create(PlanCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Plan>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, Urls.Plans, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Plan Get(string planId, RequestOptions requestOptions = null)
        {
            return Mapper<Plan>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.Plans}/{WebUtility.UrlEncode(planId)}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Plan Delete(string planId, RequestOptions requestOptions = null)
        {
            return Mapper<Plan>.MapFromJson(
                Requestor.Delete(
                    $"{Urls.Plans}/{WebUtility.UrlEncode(planId)}",
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Plan Update(string planId, PlanUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Plan>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{Urls.Plans}/{WebUtility.UrlEncode(planId)}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<Plan> List(PlanListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<Plan>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, Urls.Plans, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Plan> CreateAsync(PlanCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Plan>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, Urls.Plans, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Plan> GetAsync(string planId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Plan>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.Plans}/{WebUtility.UrlEncode(planId)}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Plan> DeleteAsync(string planId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Plan>.MapFromJson(
                await Requestor.DeleteAsync(
                    $"{Urls.Plans}/{WebUtility.UrlEncode(planId)}",
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Plan> UpdateAsync(string planId, PlanUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Plan>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{Urls.Plans}/{WebUtility.UrlEncode(planId)}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<Plan>> ListAsync(PlanListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<Plan>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, Urls.Plans, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
