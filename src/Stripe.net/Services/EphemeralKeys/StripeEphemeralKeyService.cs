using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeEphemeralKeyService : StripeBasicService<StripeEphemeralKey>
    {
        public StripeEphemeralKeyService(string apiKey = null) : base(apiKey) { }

        // Sync
        public virtual StripeEphemeralKey Create(StripeEphemeralKeyCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Post(Urls.EphemeralKeys, requestOptions, createOptions);
        }

        public virtual StripeDeleted Delete(string keyId, StripeRequestOptions requestOptions = null)
        {
            return DeleteEntity($"{Urls.EphemeralKeys}/{keyId}", requestOptions);
        }



        // Async
        public virtual Task<StripeEphemeralKey> CreateAsync(StripeEphemeralKeyCreateOptions createOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync(Urls.EphemeralKeys, requestOptions, cancellationToken, createOptions);
        }

        public virtual Task<StripeDeleted> DeleteAsync(string keyId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteEntityAsync($"{Urls.EphemeralKeys}/{keyId}", requestOptions, cancellationToken);
        }
    }
}
