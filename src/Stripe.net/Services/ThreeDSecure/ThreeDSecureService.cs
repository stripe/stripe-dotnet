namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public class ThreeDSecureService : Service<ThreeDSecure>,
        ICreatable<ThreeDSecure, ThreeDSecureCreateOptions>,
        IRetrievable<ThreeDSecure, ThreeDSecureGetOptions>
    {
        public ThreeDSecureService()
            : base(null)
        {
        }

        public ThreeDSecureService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/3d_secure";

        public virtual ThreeDSecure Create(ThreeDSecureCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<ThreeDSecure> CreateAsync(ThreeDSecureCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual ThreeDSecure Get(string id, ThreeDSecureGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<ThreeDSecure> GetAsync(string id, ThreeDSecureGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
