namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class StripeEphemeralKeyService : StripeBasicService<StripeEphemeralKey>
    {
        public StripeEphemeralKeyService()
            : base(null)
        {
        }

        public StripeEphemeralKeyService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual StripeEphemeralKey Create(StripeEphemeralKeyCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            if (createOptions.StripeVersion == null)
            {
                throw new System.ArgumentException("The StripeVersion parameter has to be set when creating an Ephemeral Key", "StripeVersion");
            }

            // Creating an ephemeral key requires a specific API version to be set. This is handled as a parameter
            // but has to be set on the StripeRequestOptions instead.
            requestOptions = requestOptions ?? new StripeRequestOptions();
            requestOptions.StripeVersion = createOptions.StripeVersion;

            return this.Post(Urls.EphemeralKeys, requestOptions, createOptions);
        }

        public virtual StripeEphemeralKey Delete(string keyId, StripeRequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.EphemeralKeys}/{keyId}", requestOptions);
        }

        public virtual Task<StripeEphemeralKey> CreateAsync(StripeEphemeralKeyCreateOptions createOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            // Creating an ephemeral key requires a specific API version to be set. This is handled as a parameter
            // but has to be set on the StripeRequestOptions instead.
            requestOptions = requestOptions ?? new StripeRequestOptions();
            requestOptions.StripeVersion = createOptions.StripeVersion;

            return this.PostAsync(Urls.EphemeralKeys, requestOptions, cancellationToken, createOptions);
        }

        public virtual Task<StripeEphemeralKey> DeleteAsync(string keyId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.EphemeralKeys}/{keyId}", requestOptions, cancellationToken);
        }
    }
}
