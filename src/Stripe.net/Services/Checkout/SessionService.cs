namespace Stripe.Checkout
{
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

        public override string BasePath => "/v1/checkout/sessions";

        public virtual Session Create(SessionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Session> CreateAsync(SessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Session Get(string sessionId, SessionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(sessionId, options, requestOptions);
        }

        public virtual Task<Session> GetAsync(string sessionId, SessionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(sessionId, options, requestOptions, cancellationToken);
        }
    }
}
