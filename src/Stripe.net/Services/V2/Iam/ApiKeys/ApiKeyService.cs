// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ApiKeyService : Service
    {
        internal ApiKeyService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ApiKeyService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Create an API key. To create a secret key in livemode, a public key for encryption must
        /// be provided.
        /// </summary>
        public virtual ApiKey Create(ApiKeyCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ApiKey>(BaseAddress.Api, HttpMethod.Post, $"/v2/iam/api_keys", options, requestOptions);
        }

        /// <summary>
        /// Create an API key. To create a secret key in livemode, a public key for encryption must
        /// be provided.
        /// </summary>
        public virtual Task<ApiKey> CreateAsync(ApiKeyCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ApiKey>(BaseAddress.Api, HttpMethod.Post, $"/v2/iam/api_keys", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Expire an API key. The specified key becomes invalid immediately.
        /// </summary>
        public virtual ApiKey Expire(string id, ApiKeyExpireOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ApiKey>(BaseAddress.Api, HttpMethod.Post, $"/v2/iam/api_keys/{WebUtility.UrlEncode(id)}/expire", options, requestOptions);
        }

        /// <summary>
        /// Expire an API key. The specified key becomes invalid immediately.
        /// </summary>
        public virtual Task<ApiKey> ExpireAsync(string id, ApiKeyExpireOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ApiKey>(BaseAddress.Api, HttpMethod.Post, $"/v2/iam/api_keys/{WebUtility.UrlEncode(id)}/expire", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve an API key. For livemode secret keys, secret tokens are only returned on
        /// creation, and never returned here.
        /// </summary>
        public virtual ApiKey Get(string id, ApiKeyGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ApiKey>(BaseAddress.Api, HttpMethod.Get, $"/v2/iam/api_keys/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve an API key. For livemode secret keys, secret tokens are only returned on
        /// creation, and never returned here.
        /// </summary>
        public virtual Task<ApiKey> GetAsync(string id, ApiKeyGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ApiKey>(BaseAddress.Api, HttpMethod.Get, $"/v2/iam/api_keys/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all API keys of an account.
        /// </summary>
        public virtual V2.StripeList<ApiKey> List(ApiKeyListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<ApiKey>>(BaseAddress.Api, HttpMethod.Get, $"/v2/iam/api_keys", options, requestOptions);
        }

        /// <summary>
        /// List all API keys of an account.
        /// </summary>
        public virtual Task<V2.StripeList<ApiKey>> ListAsync(ApiKeyListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<ApiKey>>(BaseAddress.Api, HttpMethod.Get, $"/v2/iam/api_keys", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all API keys of an account.
        /// </summary>
        public virtual IEnumerable<ApiKey> ListAutoPaging(ApiKeyListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ApiKey>($"/v2/iam/api_keys", options, requestOptions);
        }

        /// <summary>
        /// List all API keys of an account.
        /// </summary>
        public virtual IAsyncEnumerable<ApiKey> ListAutoPagingAsync(ApiKeyListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ApiKey>($"/v2/iam/api_keys", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Rotate an API key. A new key with the same properties is created and returned. The
        /// existing key is expired immediately, unless an expiry time is specified.
        /// </summary>
        public virtual ApiKey Rotate(string id, ApiKeyRotateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ApiKey>(BaseAddress.Api, HttpMethod.Post, $"/v2/iam/api_keys/{WebUtility.UrlEncode(id)}/rotate", options, requestOptions);
        }

        /// <summary>
        /// Rotate an API key. A new key with the same properties is created and returned. The
        /// existing key is expired immediately, unless an expiry time is specified.
        /// </summary>
        public virtual Task<ApiKey> RotateAsync(string id, ApiKeyRotateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ApiKey>(BaseAddress.Api, HttpMethod.Post, $"/v2/iam/api_keys/{WebUtility.UrlEncode(id)}/rotate", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Update an API key. Only parameters that are specified in the request will be updated.
        /// </summary>
        public virtual ApiKey Update(string id, ApiKeyUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ApiKey>(BaseAddress.Api, HttpMethod.Post, $"/v2/iam/api_keys/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Update an API key. Only parameters that are specified in the request will be updated.
        /// </summary>
        public virtual Task<ApiKey> UpdateAsync(string id, ApiKeyUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ApiKey>(BaseAddress.Api, HttpMethod.Post, $"/v2/iam/api_keys/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
