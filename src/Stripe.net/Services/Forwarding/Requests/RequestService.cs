// File generated from our OpenAPI spec
namespace Stripe.Forwarding
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class RequestService : Service<Request>,
        ICreatable<Request, RequestCreateOptions>,
        IListable<Request, RequestListOptions>,
        IRetrievable<Request, RequestGetOptions>
    {
        public RequestService()
        {
        }

        public RequestService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/forwarding/requests";

        /// <summary>
        /// <p>Creates a ForwardingRequest object.</p>.
        /// </summary>
        public virtual Request Create(RequestCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Request>(HttpMethod.Post, $"/v1/forwarding/requests", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a ForwardingRequest object.</p>.
        /// </summary>
        public virtual Task<Request> CreateAsync(RequestCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Request>(HttpMethod.Post, $"/v1/forwarding/requests", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a ForwardingRequest object.</p>.
        /// </summary>
        public virtual Request Get(string id, RequestGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Request>(HttpMethod.Get, $"/v1/forwarding/requests/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a ForwardingRequest object.</p>.
        /// </summary>
        public virtual Task<Request> GetAsync(string id, RequestGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Request>(HttpMethod.Get, $"/v1/forwarding/requests/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists all ForwardingRequest objects.</p>.
        /// </summary>
        public virtual StripeList<Request> List(RequestListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Request>>(HttpMethod.Get, $"/v1/forwarding/requests", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists all ForwardingRequest objects.</p>.
        /// </summary>
        public virtual Task<StripeList<Request>> ListAsync(RequestListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Request>>(HttpMethod.Get, $"/v1/forwarding/requests", options, requestOptions, cancellationToken);
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
