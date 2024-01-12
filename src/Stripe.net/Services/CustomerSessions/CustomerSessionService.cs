// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CustomerSessionService : Service<CustomerSession>,
        ICreatable<CustomerSession, CustomerSessionCreateOptions>
    {
        public CustomerSessionService()
            : base(null)
        {
        }

        public CustomerSessionService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/customer_sessions";

        public virtual CustomerSession Create(CustomerSessionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<CustomerSession>(HttpMethod.Post, $"/v1/customer_sessions", options, requestOptions);
        }

        public virtual Task<CustomerSession> CreateAsync(CustomerSessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CustomerSession>(HttpMethod.Post, $"/v1/customer_sessions", options, requestOptions, cancellationToken);
        }
    }
}
