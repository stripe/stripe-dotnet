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

        public override string BasePath => "/v1/ephemeral_keys";

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

            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<EphemeralKey> CreateAsync(EphemeralKeyCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            // Creating an ephemeral key requires a specific API version to be set. This is handled as a parameter
            // but has to be set on the RequestOptions instead.
            requestOptions = requestOptions ?? new RequestOptions();
            requestOptions.StripeVersion = options.StripeVersion;

            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual EphemeralKey Delete(string keyId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(keyId, null, requestOptions);
        }

        public virtual Task<EphemeralKey> DeleteAsync(string keyId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync(keyId, null, requestOptions, cancellationToken);
        }
    }
}
