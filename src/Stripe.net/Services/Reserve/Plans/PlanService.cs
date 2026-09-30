// File generated from our OpenAPI spec
namespace Stripe.Reserve
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PlanService : Service,
        IListable<Plan, PlanListOptions>,
        IRetrievable<Plan, PlanGetOptions>
    {
        public PlanService()
        {
        }

        internal PlanService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public PlanService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieve a ReservePlan.</p>.
        /// </summary>
        public virtual Plan Get(string id, PlanGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Plan>(BaseAddress.Api, HttpMethod.Get, $"/v1/reserve/plans/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a ReservePlan.</p>.
        /// </summary>
        public virtual Task<Plan> GetAsync(string id, PlanGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Plan>(BaseAddress.Api, HttpMethod.Get, $"/v1/reserve/plans/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of ReservePlans previously created. The ReservePlans are returned in
        /// sorted order, with the most recent ReservePlans appearing first.</p>.
        /// </summary>
        public virtual StripeList<Plan> List(PlanListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Plan>>(BaseAddress.Api, HttpMethod.Get, $"/v1/reserve/plans", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of ReservePlans previously created. The ReservePlans are returned in
        /// sorted order, with the most recent ReservePlans appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<Plan>> ListAsync(PlanListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Plan>>(BaseAddress.Api, HttpMethod.Get, $"/v1/reserve/plans", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of ReservePlans previously created. The ReservePlans are returned in
        /// sorted order, with the most recent ReservePlans appearing first.</p>.
        /// </summary>
        public virtual IEnumerable<Plan> ListAutoPaging(PlanListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Plan>($"/v1/reserve/plans", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of ReservePlans previously created. The ReservePlans are returned in
        /// sorted order, with the most recent ReservePlans appearing first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Plan> ListAutoPagingAsync(PlanListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Plan>($"/v1/reserve/plans", options, requestOptions, cancellationToken);
        }
    }
}
