// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class RequestedSessionService : Service,
        ICreatable<RequestedSession, RequestedSessionCreateOptions>,
        IRetrievable<RequestedSession, RequestedSessionGetOptions>,
        IUpdatable<RequestedSession, RequestedSessionUpdateOptions>
    {
        public RequestedSessionService()
        {
        }

        internal RequestedSessionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public RequestedSessionService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Confirms a requested session</p>.
        /// </summary>
        public virtual RequestedSession Confirm(string id, RequestedSessionConfirmOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<RequestedSession>(BaseAddress.Api, HttpMethod.Post, $"/v1/delegated_checkout/requested_sessions/{WebUtility.UrlEncode(id)}/confirm", options, requestOptions);
        }

        /// <summary>
        /// <p>Confirms a requested session</p>.
        /// </summary>
        public virtual Task<RequestedSession> ConfirmAsync(string id, RequestedSessionConfirmOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RequestedSession>(BaseAddress.Api, HttpMethod.Post, $"/v1/delegated_checkout/requested_sessions/{WebUtility.UrlEncode(id)}/confirm", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Creates a requested session</p>.
        /// </summary>
        public virtual RequestedSession Create(RequestedSessionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<RequestedSession>(BaseAddress.Api, HttpMethod.Post, $"/v1/delegated_checkout/requested_sessions", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a requested session</p>.
        /// </summary>
        public virtual Task<RequestedSession> CreateAsync(RequestedSessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RequestedSession>(BaseAddress.Api, HttpMethod.Post, $"/v1/delegated_checkout/requested_sessions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Expires a requested session</p>.
        /// </summary>
        public virtual RequestedSession Expire(string id, RequestedSessionExpireOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<RequestedSession>(BaseAddress.Api, HttpMethod.Post, $"/v1/delegated_checkout/requested_sessions/{WebUtility.UrlEncode(id)}/expire", options, requestOptions);
        }

        /// <summary>
        /// <p>Expires a requested session</p>.
        /// </summary>
        public virtual Task<RequestedSession> ExpireAsync(string id, RequestedSessionExpireOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RequestedSession>(BaseAddress.Api, HttpMethod.Post, $"/v1/delegated_checkout/requested_sessions/{WebUtility.UrlEncode(id)}/expire", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a requested session</p>.
        /// </summary>
        public virtual RequestedSession Get(string id, RequestedSessionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<RequestedSession>(BaseAddress.Api, HttpMethod.Get, $"/v1/delegated_checkout/requested_sessions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a requested session</p>.
        /// </summary>
        public virtual Task<RequestedSession> GetAsync(string id, RequestedSessionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RequestedSession>(BaseAddress.Api, HttpMethod.Get, $"/v1/delegated_checkout/requested_sessions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates a requested session</p>.
        /// </summary>
        public virtual RequestedSession Update(string id, RequestedSessionUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<RequestedSession>(BaseAddress.Api, HttpMethod.Post, $"/v1/delegated_checkout/requested_sessions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates a requested session</p>.
        /// </summary>
        public virtual Task<RequestedSession> UpdateAsync(string id, RequestedSessionUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RequestedSession>(BaseAddress.Api, HttpMethod.Post, $"/v1/delegated_checkout/requested_sessions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
