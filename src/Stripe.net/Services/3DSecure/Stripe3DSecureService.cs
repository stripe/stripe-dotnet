using System;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    [Obsolete("Use the StripeSourceService instead.")]
    public class Stripe3DSecureService : StripeBasicService<Stripe3DSecure>
    {
        public Stripe3DSecureService() : base(null) { }
        public Stripe3DSecureService(string apiKey) : base(apiKey) { }



        // Sync
        public virtual Stripe3DSecure Create(Stripe3DSecureCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/3d_secure", requestOptions, createOptions);
        }



        // Async
        public virtual Task<Stripe3DSecure> CreateAsync(Stripe3DSecureCreateOptions createOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/3d_secure", requestOptions, cancellationToken, createOptions);
        }
    }
}
