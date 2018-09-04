namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class EphemeralKeyService : BasicService<EphemeralKey>,
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

        public virtual EphemeralKey Create(EphemeralKeyCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            if (createOptions.StripeVersion == null)
            {
                throw new System.ArgumentException("The StripeVersion parameter has to be set when creating an Ephemeral Key", "StripeVersion");
            }

            // Creating an ephemeral key requires a specific API version to be set. This is handled as a parameter
            // but has to be set on the RequestOptions instead.
            requestOptions = requestOptions ?? new RequestOptions();
            requestOptions.StripeVersion = createOptions.StripeVersion;

            return this.Post(Urls.EphemeralKeys, requestOptions, createOptions);
        }

        public virtual EphemeralKey Delete(string keyId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.EphemeralKeys}/{keyId}", requestOptions);
        }

        public virtual Task<EphemeralKey> CreateAsync(EphemeralKeyCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            // Creating an ephemeral key requires a specific API version to be set. This is handled as a parameter
            // but has to be set on the RequestOptions instead.
            requestOptions = requestOptions ?? new RequestOptions();
            requestOptions.StripeVersion = createOptions.StripeVersion;

            return this.PostAsync(Urls.EphemeralKeys, requestOptions, cancellationToken, createOptions);
        }

        public virtual Task<EphemeralKey> DeleteAsync(string keyId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.EphemeralKeys}/{keyId}", requestOptions, cancellationToken);
        }
    }
}
