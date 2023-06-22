// File generated from our OpenAPI spec
namespace Stripe
{
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
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<CustomerSession> CreateAsync(CustomerSessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }
    }
}
