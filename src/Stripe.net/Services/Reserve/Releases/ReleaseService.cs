// File generated from our OpenAPI spec
namespace Stripe.Reserve
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReleaseService : Service,
        IListable<Release, ReleaseListOptions>,
        IRetrievable<Release, ReleaseGetOptions>
    {
        public ReleaseService()
        {
        }

        internal ReleaseService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public ReleaseService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieve a ReserveRelease.</p>.
        /// </summary>
        public virtual Release Get(string id, ReleaseGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Release>(BaseAddress.Api, HttpMethod.Get, $"/v1/reserve/releases/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a ReserveRelease.</p>.
        /// </summary>
        public virtual Task<Release> GetAsync(string id, ReleaseGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Release>(BaseAddress.Api, HttpMethod.Get, $"/v1/reserve/releases/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of ReserveReleases previously created. The ReserveReleases are
        /// returned in sorted order, with the most recent ReserveReleases appearing first.</p>.
        /// </summary>
        public virtual StripeList<Release> List(ReleaseListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Release>>(BaseAddress.Api, HttpMethod.Get, $"/v1/reserve/releases", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of ReserveReleases previously created. The ReserveReleases are
        /// returned in sorted order, with the most recent ReserveReleases appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<Release>> ListAsync(ReleaseListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Release>>(BaseAddress.Api, HttpMethod.Get, $"/v1/reserve/releases", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of ReserveReleases previously created. The ReserveReleases are
        /// returned in sorted order, with the most recent ReserveReleases appearing first.</p>.
        /// </summary>
        public virtual IEnumerable<Release> ListAutoPaging(ReleaseListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Release>($"/v1/reserve/releases", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of ReserveReleases previously created. The ReserveReleases are
        /// returned in sorted order, with the most recent ReserveReleases appearing first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Release> ListAutoPagingAsync(ReleaseListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Release>($"/v1/reserve/releases", options, requestOptions, cancellationToken);
        }
    }
}
