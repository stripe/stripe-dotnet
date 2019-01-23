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

        public SessionService(string apiKey)
            : base(apiKey)
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

        public virtual Session Get(string sessionId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(sessionId, null, requestOptions);
        }

        public virtual Task<Session> GetAsync(string sessionId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(sessionId, null, requestOptions, cancellationToken);
        }
    }
}
