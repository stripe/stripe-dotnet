// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

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
            return this.Request<Session>(HttpMethod.Post, $"/v1/billing_portal/sessions", options, requestOptions);
        }

        public virtual Task<Session> CreateAsync(SessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Session>(HttpMethod.Post, $"/v1/billing_portal/sessions", options, requestOptions, cancellationToken);
        }
    }
}
