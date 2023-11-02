// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SessionService : Service<Session>,
        ICreatable<Session, SessionCreateOptions>,
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

        public override string BasePath => "/v1/financial_connections/sessions";

        public virtual Session Create(SessionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Session>(HttpMethod.Post, $"/v1/financial_connections/sessions", options, requestOptions);
        }

        public virtual Task<Session> CreateAsync(SessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Session>(HttpMethod.Post, $"/v1/financial_connections/sessions", options, requestOptions, cancellationToken);
        }

        public virtual Session Get(string id, SessionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Session>(HttpMethod.Get, $"/v1/financial_connections/sessions/{id}", options, requestOptions);
        }

        public virtual Task<Session> GetAsync(string id, SessionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Session>(HttpMethod.Get, $"/v1/financial_connections/sessions/{id}", options, requestOptions, cancellationToken);
        }
    }
}
