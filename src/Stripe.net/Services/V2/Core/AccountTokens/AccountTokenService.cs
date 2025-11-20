// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountTokenService : Service
    {
        internal AccountTokenService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal AccountTokenService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Creates an Account Token.
        /// </summary>
        public virtual AccountToken Create(AccountTokenCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<AccountToken>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/account_tokens", options, requestOptions);
        }

        /// <summary>
        /// Creates an Account Token.
        /// </summary>
        public virtual Task<AccountToken> CreateAsync(AccountTokenCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AccountToken>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/account_tokens", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves an Account Token.
        /// </summary>
        public virtual AccountToken Get(string id, AccountTokenGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<AccountToken>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/account_tokens/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves an Account Token.
        /// </summary>
        public virtual Task<AccountToken> GetAsync(string id, AccountTokenGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AccountToken>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/account_tokens/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
