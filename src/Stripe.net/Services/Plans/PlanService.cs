namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class PlanService : Service<Plan>,
        ICreatable<Plan, PlanCreateOptions>,
        IDeletable<Plan, PlanDeleteOptions>,
        IListable<Plan, PlanListOptions>,
        IRetrievable<Plan, PlanGetOptions>,
        IUpdatable<Plan, PlanUpdateOptions>
    {
        public PlanService()
            : base(null)
        {
        }

        public PlanService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/plans";

        public virtual Plan Create(PlanCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Plan> CreateAsync(PlanCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Plan Delete(string planId, PlanDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(planId, options, requestOptions);
        }

        public virtual Task<Plan> DeleteAsync(string planId, PlanDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteEntityAsync(planId, options, requestOptions, cancellationToken);
        }

        public virtual Plan Get(string planId, PlanGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(planId, options, requestOptions);
        }

        public virtual Task<Plan> GetAsync(string planId, PlanGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(planId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Plan> List(PlanListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Plan>> ListAsync(PlanListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Plan> ListAutoPaging(PlanListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<Plan> ListAutoPagingAsync(PlanListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
#endif

        public virtual Plan Update(string planId, PlanUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(planId, options, requestOptions);
        }

        public virtual Task<Plan> UpdateAsync(string planId, PlanUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(planId, options, requestOptions, cancellationToken);
        }
    }
}
