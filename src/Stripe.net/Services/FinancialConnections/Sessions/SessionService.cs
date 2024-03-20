// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SessionService : Service<Session>,
        ICreatable<Session, SessionCreateOptions>,
        IRetrievable<Session, SessionGetOptions>
    {
        public SessionService()
        {
        }

        public SessionService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/financial_connections/sessions";

        /// <summary>
        /// <p>To launch the Financial Connections authorization flow, create a <c>Session</c>. The
        /// session’s <c>client_secret</c> can be used to launch the flow using Stripe.js.</p>.
        /// </summary>
        public virtual Session Create(SessionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Session>(HttpMethod.Post, $"/v1/financial_connections/sessions", options, requestOptions);
        }

        /// <summary>
        /// <p>To launch the Financial Connections authorization flow, create a <c>Session</c>. The
        /// session’s <c>client_secret</c> can be used to launch the flow using Stripe.js.</p>.
        /// </summary>
        public virtual Task<Session> CreateAsync(SessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Session>(HttpMethod.Post, $"/v1/financial_connections/sessions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of a Financial Connections <c>Session</c></p>.
        /// </summary>
        public virtual Session Get(string id, SessionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Session>(HttpMethod.Get, $"/v1/financial_connections/sessions/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of a Financial Connections <c>Session</c></p>.
        /// </summary>
        public virtual Task<Session> GetAsync(string id, SessionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Session>(HttpMethod.Get, $"/v1/financial_connections/sessions/{id}", options, requestOptions, cancellationToken);
        }
    }
}
