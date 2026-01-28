// File generated from our OpenAPI spec
namespace Stripe.Reserve
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class HoldService : Service,
        IListable<Hold, HoldListOptions>,
        IRetrievable<Hold, HoldGetOptions>
    {
        public HoldService()
        {
        }

        internal HoldService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public HoldService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieve a ReserveHold.</p>.
        /// </summary>
        public virtual Hold Get(string id, HoldGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Hold>(BaseAddress.Api, HttpMethod.Get, $"/v1/reserve/holds/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a ReserveHold.</p>.
        /// </summary>
        public virtual Task<Hold> GetAsync(string id, HoldGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Hold>(BaseAddress.Api, HttpMethod.Get, $"/v1/reserve/holds/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of ReserveHolds previously created. The ReserveHolds are returned in
        /// sorted order, with the most recent ReserveHolds appearing first.</p>.
        /// </summary>
        public virtual StripeList<Hold> List(HoldListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Hold>>(BaseAddress.Api, HttpMethod.Get, $"/v1/reserve/holds", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of ReserveHolds previously created. The ReserveHolds are returned in
        /// sorted order, with the most recent ReserveHolds appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<Hold>> ListAsync(HoldListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Hold>>(BaseAddress.Api, HttpMethod.Get, $"/v1/reserve/holds", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of ReserveHolds previously created. The ReserveHolds are returned in
        /// sorted order, with the most recent ReserveHolds appearing first.</p>.
        /// </summary>
        public virtual IEnumerable<Hold> ListAutoPaging(HoldListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Hold>($"/v1/reserve/holds", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of ReserveHolds previously created. The ReserveHolds are returned in
        /// sorted order, with the most recent ReserveHolds appearing first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Hold> ListAutoPagingAsync(HoldListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Hold>($"/v1/reserve/holds", options, requestOptions, cancellationToken);
        }
    }
}
