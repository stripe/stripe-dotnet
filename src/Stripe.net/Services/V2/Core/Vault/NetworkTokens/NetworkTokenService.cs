// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class NetworkTokenService : Service
    {
        internal NetworkTokenService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal NetworkTokenService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Create or Return a Network Token Using Raw Card Data.
        /// </summary>
        public virtual NetworkToken Create(NetworkTokenCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<NetworkToken>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/vault/network_tokens", options, requestOptions);
        }

        /// <summary>
        /// Create or Return a Network Token Using Raw Card Data.
        /// </summary>
        public virtual Task<NetworkToken> CreateAsync(NetworkTokenCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<NetworkToken>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/vault/network_tokens", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Creates or returns a Network Token from an existing card reference.
        /// </summary>
        public virtual NetworkToken CreateFromCredential(NetworkTokenCreateFromCredentialOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<NetworkToken>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/vault/network_tokens/create_from_credential", options, requestOptions);
        }

        /// <summary>
        /// Creates or returns a Network Token from an existing card reference.
        /// </summary>
        public virtual Task<NetworkToken> CreateFromCredentialAsync(NetworkTokenCreateFromCredentialOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<NetworkToken>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/vault/network_tokens/create_from_credential", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Every successful call generates a new cryptogram, and retrying can generate another
        /// cryptogram. The cryptogram is returned only in this response and is never persisted.
        /// </summary>
        public virtual NetworkToken GenerateCryptogram(string id, NetworkTokenGenerateCryptogramOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<NetworkToken>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/vault/network_tokens/{WebUtility.UrlEncode(id)}/generate_cryptogram", options, requestOptions);
        }

        /// <summary>
        /// Every successful call generates a new cryptogram, and retrying can generate another
        /// cryptogram. The cryptogram is returned only in this response and is never persisted.
        /// </summary>
        public virtual Task<NetworkToken> GenerateCryptogramAsync(string id, NetworkTokenGenerateCryptogramOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<NetworkToken>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/vault/network_tokens/{WebUtility.UrlEncode(id)}/generate_cryptogram", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves an existing network token.
        /// </summary>
        public virtual NetworkToken Get(string id, NetworkTokenGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<NetworkToken>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/vault/network_tokens/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves an existing network token.
        /// </summary>
        public virtual Task<NetworkToken> GetAsync(string id, NetworkTokenGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<NetworkToken>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/vault/network_tokens/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
