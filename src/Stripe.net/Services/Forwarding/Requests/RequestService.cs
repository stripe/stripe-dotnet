// File generated from our OpenAPI spec
namespace Stripe.Forwarding
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class RequestService : Service,
        ICreatable<Request, RequestCreateOptions>,
        IListable<Request, RequestListOptions>,
        IRetrievable<Request, RequestGetOptions>
    {
        public RequestService()
        {
        }

        internal RequestService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public RequestService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a ForwardingRequest object.</p>.
        /// </summary>
        public virtual Request Create(RequestCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Request>(BaseAddress.Api, HttpMethod.Post, $"/v1/forwarding/requests", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a ForwardingRequest object.</p>.
        /// </summary>
        public virtual Task<Request> CreateAsync(RequestCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Request>(BaseAddress.Api, HttpMethod.Post, $"/v1/forwarding/requests", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a ForwardingRequest object.</p>.
        /// </summary>
        public virtual Request Get(string id, RequestGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Request>(BaseAddress.Api, HttpMethod.Get, $"/v1/forwarding/requests/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a ForwardingRequest object.</p>.
        /// </summary>
        public virtual Task<Request> GetAsync(string id, RequestGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Request>(BaseAddress.Api, HttpMethod.Get, $"/v1/forwarding/requests/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists all ForwardingRequest objects.</p>.
        /// </summary>
        public virtual StripeList<Request> List(RequestListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Request>>(BaseAddress.Api, HttpMethod.Get, $"/v1/forwarding/requests", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists all ForwardingRequest objects.</p>.
        /// </summary>
        public virtual Task<StripeList<Request>> ListAsync(RequestListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Request>>(BaseAddress.Api, HttpMethod.Get, $"/v1/forwarding/requests", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists all ForwardingRequest objects.</p>.
        /// </summary>
        public virtual IEnumerable<Request> ListAutoPaging(RequestListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Request>($"/v1/forwarding/requests", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists all ForwardingRequest objects.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Request> ListAutoPagingAsync(RequestListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Request>($"/v1/forwarding/requests", options, requestOptions, cancellationToken);
        }
    }
}
