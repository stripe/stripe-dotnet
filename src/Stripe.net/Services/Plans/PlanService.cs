// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
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
        {
        }

        public PlanService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/plans";

        /// <summary>
        /// <p>You can now model subscriptions more flexibly using the <a
        /// href="https://stripe.com/docs/api#prices">Prices API</a>. It replaces the Plans API and
        /// is backwards compatible to simplify your migration.</p>.
        /// </summary>
        public virtual Plan Create(PlanCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Plan>(HttpMethod.Post, $"/v1/plans", options, requestOptions);
        }

        /// <summary>
        /// <p>You can now model subscriptions more flexibly using the <a
        /// href="https://stripe.com/docs/api#prices">Prices API</a>. It replaces the Plans API and
        /// is backwards compatible to simplify your migration.</p>.
        /// </summary>
        public virtual Task<Plan> CreateAsync(PlanCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Plan>(HttpMethod.Post, $"/v1/plans", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Deleting plans means new subscribers can’t be added. Existing subscribers aren’t
        /// affected.</p>.
        /// </summary>
        public virtual Plan Delete(string id, PlanDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Plan>(HttpMethod.Delete, $"/v1/plans/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Deleting plans means new subscribers can’t be added. Existing subscribers aren’t
        /// affected.</p>.
        /// </summary>
        public virtual Task<Plan> DeleteAsync(string id, PlanDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Plan>(HttpMethod.Delete, $"/v1/plans/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the plan with the given ID.</p>.
        /// </summary>
        public virtual Plan Get(string id, PlanGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Plan>(HttpMethod.Get, $"/v1/plans/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the plan with the given ID.</p>.
        /// </summary>
        public virtual Task<Plan> GetAsync(string id, PlanGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Plan>(HttpMethod.Get, $"/v1/plans/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your plans.</p>.
        /// </summary>
        public virtual StripeList<Plan> List(PlanListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Plan>>(HttpMethod.Get, $"/v1/plans", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your plans.</p>.
        /// </summary>
        public virtual Task<StripeList<Plan>> ListAsync(PlanListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Plan>>(HttpMethod.Get, $"/v1/plans", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your plans.</p>.
        /// </summary>
        public virtual IEnumerable<Plan> ListAutoPaging(PlanListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Plan>($"/v1/plans", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your plans.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Plan> ListAutoPagingAsync(PlanListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Plan>($"/v1/plans", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the specified plan by setting the values of the parameters passed. Any
        /// parameters not provided are left unchanged. By design, you cannot change a plan’s ID,
        /// amount, currency, or billing cycle.</p>.
        /// </summary>
        public virtual Plan Update(string id, PlanUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Plan>(HttpMethod.Post, $"/v1/plans/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the specified plan by setting the values of the parameters passed. Any
        /// parameters not provided are left unchanged. By design, you cannot change a plan’s ID,
        /// amount, currency, or billing cycle.</p>.
        /// </summary>
        public virtual Task<Plan> UpdateAsync(string id, PlanUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Plan>(HttpMethod.Post, $"/v1/plans/{id}", options, requestOptions, cancellationToken);
        }
    }
}
