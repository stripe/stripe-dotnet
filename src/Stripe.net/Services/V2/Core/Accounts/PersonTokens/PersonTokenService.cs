// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Accounts
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PersonTokenService : Service
    {
        internal PersonTokenService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal PersonTokenService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Creates a Person Token associated with an Account.
        /// </summary>
        public virtual V2.Core.AccountPersonToken Create(string id, PersonTokenCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Core.AccountPersonToken>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/accounts/{WebUtility.UrlEncode(id)}/person_tokens", options, requestOptions);
        }

        /// <summary>
        /// Creates a Person Token associated with an Account.
        /// </summary>
        public virtual Task<V2.Core.AccountPersonToken> CreateAsync(string id, PersonTokenCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Core.AccountPersonToken>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/accounts/{WebUtility.UrlEncode(id)}/person_tokens", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves a Person Token associated with an Account.
        /// </summary>
        public virtual V2.Core.AccountPersonToken Get(string parentId, string id, PersonTokenGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Core.AccountPersonToken>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/accounts/{WebUtility.UrlEncode(parentId)}/person_tokens/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a Person Token associated with an Account.
        /// </summary>
        public virtual Task<V2.Core.AccountPersonToken> GetAsync(string parentId, string id, PersonTokenGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Core.AccountPersonToken>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/accounts/{WebUtility.UrlEncode(parentId)}/person_tokens/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
