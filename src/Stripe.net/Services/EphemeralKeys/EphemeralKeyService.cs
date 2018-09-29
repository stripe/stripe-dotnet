namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class EphemeralKeyService : Service<EphemeralKey>,
        ICreatable<EphemeralKey, EphemeralKeyCreateOptions>,
        IDeletable<EphemeralKey>
    {
        public EphemeralKeyService()
            : base(null)
        {
        }

        public EphemeralKeyService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual EphemeralKey Create(EphemeralKeyCreateOptions options, RequestOptions requestOptions = null)
        {
            if (options.StripeVersion == null)
            {
                throw new System.ArgumentException("The StripeVersion parameter has to be set when creating an Ephemeral Key", "StripeVersion");
            }

            // Creating an ephemeral key requires a specific API version to be set. This is handled as a parameter
            // but has to be set on the RequestOptions instead.
            requestOptions = requestOptions ?? new RequestOptions();
            requestOptions.StripeVersion = options.StripeVersion;

            return this.Post($"{Urls.BaseUrl}/ephemeral_keys", requestOptions, options);
        }

        public virtual EphemeralKey Delete(string keyId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.BaseUrl}/ephemeral_keys/{keyId}", requestOptions);
        }

        public virtual Task<EphemeralKey> CreateAsync(EphemeralKeyCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            // Creating an ephemeral key requires a specific API version to be set. This is handled as a parameter
            // but has to be set on the RequestOptions instead.
            requestOptions = requestOptions ?? new RequestOptions();
            requestOptions.StripeVersion = options.StripeVersion;

            return this.PostAsync($"{Urls.BaseUrl}/ephemeral_keys", requestOptions, cancellationToken, options);
        }

        public virtual Task<EphemeralKey> DeleteAsync(string keyId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.BaseUrl}/ephemeral_keys/{keyId}", requestOptions, cancellationToken);
        }
    }
}
