namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    [Obsolete("Use the SourceService instead.")]
    public class ThreeDSecureService : BasicService<ThreeDSecure>,
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

        public virtual ThreeDSecure Create(ThreeDSecureCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/3d_secure", requestOptions, createOptions);
        }

        public virtual Task<ThreeDSecure> CreateAsync(ThreeDSecureCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/3d_secure", requestOptions, cancellationToken, createOptions);
        }
    }
}
