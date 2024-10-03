// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SessionService : Service<Session>,
        ICreatable<Session, SessionCreateOptions>
    {
        public SessionService()
        {
        }

        internal SessionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public SessionService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a session of the customer portal.</p>.
        /// </summary>
        public virtual Session Create(SessionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Session>(BaseAddress.Api, HttpMethod.Post, $"/v1/billing_portal/sessions", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a session of the customer portal.</p>.
        /// </summary>
        public virtual Task<Session> CreateAsync(SessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Session>(BaseAddress.Api, HttpMethod.Post, $"/v1/billing_portal/sessions", options, requestOptions, cancellationToken);
        }
    }
}
