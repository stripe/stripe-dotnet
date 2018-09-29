namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class PlanService : Service<Plan>,
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

        public virtual Plan Create(PlanCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/plans", requestOptions, options);
        }

        public virtual Task<Plan> CreateAsync(PlanCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/plans", requestOptions, cancellationToken, options);
        }

        public virtual Plan Delete(string planId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.BaseUrl}/plans/{planId}", requestOptions);
        }

        public virtual Task<Plan> DeleteAsync(string planId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.BaseUrl}/plans/{planId}", requestOptions, cancellationToken);
        }

        public virtual Plan Get(string planId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/plans/{planId}", requestOptions);
        }

        public virtual Task<Plan> GetAsync(string planId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/plans/{planId}", requestOptions, cancellationToken);
        }

        public virtual StripeList<Plan> List(PlanListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/plans", requestOptions, options);
        }

        public virtual Task<StripeList<Plan>> ListAsync(PlanListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/plans", requestOptions, cancellationToken, options);
        }

        public virtual Plan Update(string planId, PlanUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/plans/{planId}", requestOptions, options);
        }

        public virtual Task<Plan> UpdateAsync(string planId, PlanUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/plans/{planId}", requestOptions, cancellationToken, options);
        }
    }
}
