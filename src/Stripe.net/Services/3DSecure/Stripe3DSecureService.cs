namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    [Obsolete("Use the SourceService instead.")]
    public class Stripe3DSecureService : BasicService<Stripe3DSecure>
    {
        public Stripe3DSecureService()
            : base(null)
        {
        }

        public Stripe3DSecureService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual Stripe3DSecure Create(Stripe3DSecureCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/3d_secure", requestOptions, createOptions);
        }

        public virtual Task<Stripe3DSecure> CreateAsync(Stripe3DSecureCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/3d_secure", requestOptions, cancellationToken, createOptions);
        }
    }
}
