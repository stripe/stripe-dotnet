namespace Stripe
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class EphemeralKeyService : Service<EphemeralKey>,
        ICreatable<EphemeralKey, EphemeralKeyCreateOptions>,
        IDeletable<EphemeralKey, EphemeralKeyDeleteOptions>
    {
        public EphemeralKeyService()
            : base()
        {
        }

        internal EphemeralKeyService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        [Obsolete("Please use the constructor that accepts an `ApiRequestor` instead.")]
        public EphemeralKeyService(IStripeClient client)
            : base(client)
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

            return this.Request<EphemeralKey>(BaseAddress.Api, HttpMethod.Post, $"/v1/ephemeral_keys", options, requestOptions);
        }

        public virtual Task<EphemeralKey> CreateAsync(EphemeralKeyCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            // Creating an ephemeral key requires a specific API version to be set. This is handled as a parameter
            // but has to be set on the RequestOptions instead.
            requestOptions = requestOptions ?? new RequestOptions();
            requestOptions.StripeVersion = options.StripeVersion;

            return this.RequestAsync<EphemeralKey>(BaseAddress.Api, HttpMethod.Post, $"/v1/ephemeral_keys", options, requestOptions, cancellationToken);
        }

        public virtual EphemeralKey Delete(string id, EphemeralKeyDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<EphemeralKey>(BaseAddress.Api, HttpMethod.Delete, $"/v1/ephemeral_keys/{id}", options, requestOptions);
        }

        public virtual Task<EphemeralKey> DeleteAsync(string id, EphemeralKeyDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<EphemeralKey>(BaseAddress.Api, HttpMethod.Delete, $"/v1/ephemeral_keys/{id}", options, requestOptions, cancellationToken);
        }
    }
}
