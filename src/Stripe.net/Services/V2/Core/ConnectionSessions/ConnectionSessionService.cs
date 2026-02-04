// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ConnectionSessionService : Service
    {
        internal ConnectionSessionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ConnectionSessionService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Create a new ConnectionSession.
        /// </summary>
        public virtual ConnectionSession Create(ConnectionSessionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ConnectionSession>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/connection_sessions", options, requestOptions);
        }

        /// <summary>
        /// Create a new ConnectionSession.
        /// </summary>
        public virtual Task<ConnectionSession> CreateAsync(ConnectionSessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ConnectionSession>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/connection_sessions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a ConnectionSession.
        /// </summary>
        public virtual ConnectionSession Get(string id, ConnectionSessionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ConnectionSession>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/connection_sessions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a ConnectionSession.
        /// </summary>
        public virtual Task<ConnectionSession> GetAsync(string id, ConnectionSessionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ConnectionSession>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/connection_sessions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
