// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
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
            return this.Request<Plan>(HttpMethod.Post, $"/v1/plans", options, requestOptions);
        }

        public virtual Task<Plan> CreateAsync(PlanCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Plan>(HttpMethod.Post, $"/v1/plans", options, requestOptions, cancellationToken);
        }

        public virtual Plan Delete(string id, PlanDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Plan>(HttpMethod.Delete, $"/v1/plans/{id}", options, requestOptions);
        }

        public virtual Task<Plan> DeleteAsync(string id, PlanDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Plan>(HttpMethod.Delete, $"/v1/plans/{id}", options, requestOptions, cancellationToken);
        }

        public virtual Plan Get(string id, PlanGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Plan>(HttpMethod.Get, $"/v1/plans/{id}", options, requestOptions);
        }

        public virtual Task<Plan> GetAsync(string id, PlanGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Plan>(HttpMethod.Get, $"/v1/plans/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Plan> List(PlanListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Plan>>(HttpMethod.Get, $"/v1/plans", options, requestOptions);
        }

        public virtual Task<StripeList<Plan>> ListAsync(PlanListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Plan>>(HttpMethod.Get, $"/v1/plans", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Plan> ListAutoPaging(PlanListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Plan>($"/v1/plans", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Plan> ListAutoPagingAsync(PlanListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Plan>($"/v1/plans", options, requestOptions, cancellationToken);
        }

        public virtual Plan Update(string id, PlanUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Plan>(HttpMethod.Post, $"/v1/plans/{id}", options, requestOptions);
        }

        public virtual Task<Plan> UpdateAsync(string id, PlanUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Plan>(HttpMethod.Post, $"/v1/plans/{id}", options, requestOptions, cancellationToken);
        }
    }
}
