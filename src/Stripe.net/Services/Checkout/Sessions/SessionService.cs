namespace Stripe.Checkout
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class SessionService : Service<Session>,
        ICreatable<Session, SessionCreateOptions>,
        IListable<Session, SessionListOptions>,
        IRetrievable<Session, SessionGetOptions>
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

        public virtual Task<Session> CreateAsync(SessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Session Get(string id, SessionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<Session> GetAsync(string id, SessionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Session> List(SessionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Session>> ListAsync(SessionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Session> ListAutoPaging(SessionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }
    }
}
