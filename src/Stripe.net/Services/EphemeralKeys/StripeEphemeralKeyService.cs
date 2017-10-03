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
            // Creating an ephemeral key requires a specific API version to be set. This is handled as a parameter
            // but has to be set on the StripeRequestOptions instead.
            if (requestOptions == null)
                requestOptions = new StripeRequestOptions();

            requestOptions.StripeVersion = createOptions.StripeVersion;

            return Post(Urls.EphemeralKeys, requestOptions, createOptions);
        }

        public virtual StripeDeleted Delete(string keyId, StripeRequestOptions requestOptions = null)
        {
            return DeleteEntity($"{Urls.EphemeralKeys}/{keyId}", requestOptions);
        }



        // Async
        public virtual Task<StripeEphemeralKey> CreateAsync(StripeEphemeralKeyCreateOptions createOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            // Creating an ephemeral key requires a specific API version to be set. This is handled as a parameter
            // but has to be set on the StripeRequestOptions instead.
            if (requestOptions == null)
                requestOptions = new StripeRequestOptions();

            requestOptions.StripeVersion = createOptions.StripeVersion;

            return PostAsync(Urls.EphemeralKeys, requestOptions, cancellationToken, createOptions);
        }

        public virtual Task<StripeDeleted> DeleteAsync(string keyId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteEntityAsync($"{Urls.EphemeralKeys}/{keyId}", requestOptions, cancellationToken);
        }
    }
}
