namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

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

        public override string BasePath => "/v1/plans";

        public bool ExpandProduct { get; set; }

        public virtual Plan Create(PlanCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Plan> CreateAsync(PlanCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Plan Delete(string planId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(planId, null, requestOptions);
        }

        public virtual Task<Plan> DeleteAsync(string planId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync(planId, null, requestOptions, cancellationToken);
        }

        public virtual Plan Get(string planId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(planId, null, requestOptions);
        }

        public virtual Task<Plan> GetAsync(string planId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(planId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<Plan> List(PlanListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Plan>> ListAsync(PlanListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Plan> ListAutoPaging(PlanListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual Plan Update(string planId, PlanUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(planId, options, requestOptions);
        }

        public virtual Task<Plan> UpdateAsync(string planId, PlanUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(planId, options, requestOptions, cancellationToken);
        }
    }
}
