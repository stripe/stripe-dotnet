namespace Stripe.BillingPortal
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class SessionService : Service<Session>,
        ICreatable<Session, SessionCreateOptions>
    {
        public SessionService()
            : base(null)
        {
        }

        public SessionService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/billing_portal/sessions";

        public virtual Session Create(SessionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Session> CreateAsync(SessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }
    }
}
