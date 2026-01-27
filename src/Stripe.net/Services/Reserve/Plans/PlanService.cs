// File generated from our OpenAPI spec
namespace Stripe.Reserve
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PlanService : Service, IRetrievable<Plan, PlanGetOptions>
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
    }
}
