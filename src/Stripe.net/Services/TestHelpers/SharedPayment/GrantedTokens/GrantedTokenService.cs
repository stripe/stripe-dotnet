// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.SharedPayment
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.SharedPayment;

    public class GrantedTokenService : Service
    {
        public GrantedTokenService()
        {
        }

        internal GrantedTokenService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public GrantedTokenService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a new test SharedPaymentGrantedToken object. This endpoint is only available
        /// in test mode and allows sellers to create SharedPaymentGrantedTokens for testing their
        /// integration</p>.
        /// </summary>
        public virtual Stripe.SharedPayment.GrantedToken Create(GrantedTokenCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.SharedPayment.GrantedToken>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/shared_payment/granted_tokens", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new test SharedPaymentGrantedToken object. This endpoint is only available
        /// in test mode and allows sellers to create SharedPaymentGrantedTokens for testing their
        /// integration</p>.
        /// </summary>
        public virtual Task<Stripe.SharedPayment.GrantedToken> CreateAsync(GrantedTokenCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.SharedPayment.GrantedToken>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/shared_payment/granted_tokens", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Revokes a test SharedPaymentGrantedToken object. This endpoint is only available in
        /// test mode and allows sellers to revoke SharedPaymentGrantedTokens for testing their
        /// integration</p>.
        /// </summary>
        public virtual Stripe.SharedPayment.GrantedToken Update(string id, GrantedTokenUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.SharedPayment.GrantedToken>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/shared_payment/granted_tokens/{WebUtility.UrlEncode(id)}/revoke", options, requestOptions);
        }

        /// <summary>
        /// <p>Revokes a test SharedPaymentGrantedToken object. This endpoint is only available in
        /// test mode and allows sellers to revoke SharedPaymentGrantedTokens for testing their
        /// integration</p>.
        /// </summary>
        public virtual Task<Stripe.SharedPayment.GrantedToken> UpdateAsync(string id, GrantedTokenUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.SharedPayment.GrantedToken>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/shared_payment/granted_tokens/{WebUtility.UrlEncode(id)}/revoke", options, requestOptions, cancellationToken);
        }
    }
}
