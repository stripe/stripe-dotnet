// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class IssuedTokenService : Service,
        ICreatable<IssuedToken, IssuedTokenCreateOptions>,
        IRetrievable<IssuedToken, IssuedTokenGetOptions>
    {
        public IssuedTokenService()
        {
        }

        internal IssuedTokenService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public IssuedTokenService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a new SharedPaymentIssuedToken object</p>.
        /// </summary>
        public virtual IssuedToken Create(IssuedTokenCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<IssuedToken>(BaseAddress.Api, HttpMethod.Post, $"/v1/shared_payment/issued_tokens", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new SharedPaymentIssuedToken object</p>.
        /// </summary>
        public virtual Task<IssuedToken> CreateAsync(IssuedTokenCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<IssuedToken>(BaseAddress.Api, HttpMethod.Post, $"/v1/shared_payment/issued_tokens", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves an existing SharedPaymentIssuedToken object</p>.
        /// </summary>
        public virtual IssuedToken Get(string id, IssuedTokenGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<IssuedToken>(BaseAddress.Api, HttpMethod.Get, $"/v1/shared_payment/issued_tokens/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves an existing SharedPaymentIssuedToken object</p>.
        /// </summary>
        public virtual Task<IssuedToken> GetAsync(string id, IssuedTokenGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<IssuedToken>(BaseAddress.Api, HttpMethod.Get, $"/v1/shared_payment/issued_tokens/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Revokes a SharedPaymentIssuedToken</p>.
        /// </summary>
        public virtual IssuedToken Revoke(string id, IssuedTokenRevokeOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<IssuedToken>(BaseAddress.Api, HttpMethod.Post, $"/v1/shared_payment/issued_tokens/{WebUtility.UrlEncode(id)}/revoke", options, requestOptions);
        }

        /// <summary>
        /// <p>Revokes a SharedPaymentIssuedToken</p>.
        /// </summary>
        public virtual Task<IssuedToken> RevokeAsync(string id, IssuedTokenRevokeOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<IssuedToken>(BaseAddress.Api, HttpMethod.Post, $"/v1/shared_payment/issued_tokens/{WebUtility.UrlEncode(id)}/revoke", options, requestOptions, cancellationToken);
        }
    }
}
