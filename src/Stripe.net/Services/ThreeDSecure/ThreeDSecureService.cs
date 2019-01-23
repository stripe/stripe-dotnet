namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    [Obsolete("Use the SourceService instead.")]
    public class ThreeDSecureService : Service<ThreeDSecure>,
        ICreatable<ThreeDSecure, ThreeDSecureCreateOptions>
    {
        public ThreeDSecureService()
            : base(null)
        {
        }

        public ThreeDSecureService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/3d_secure";

        public virtual ThreeDSecure Create(ThreeDSecureCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<ThreeDSecure> CreateAsync(ThreeDSecureCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }
    }
}
