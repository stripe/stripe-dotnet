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

        public SessionService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/billing_portal/sessions";

        /// <summary>
        /// <p>Creates a session of the customer portal.</p>.
        /// </summary>
        public virtual Session Create(SessionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Session>(HttpMethod.Post, $"/v1/billing_portal/sessions", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a session of the customer portal.</p>.
        /// </summary>
        public virtual Task<Session> CreateAsync(SessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Session>(HttpMethod.Post, $"/v1/billing_portal/sessions", options, requestOptions, cancellationToken);
        }
    }
}
