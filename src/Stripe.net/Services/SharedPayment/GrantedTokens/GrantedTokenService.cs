// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class GrantedTokenService : Service,
        IRetrievable<GrantedToken, GrantedTokenGetOptions>
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
        /// <p>Retrieves an existing SharedPaymentGrantedToken object</p>.
        /// </summary>
        public virtual GrantedToken Get(string id, GrantedTokenGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<GrantedToken>(BaseAddress.Api, HttpMethod.Get, $"/v1/shared_payment/granted_tokens/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves an existing SharedPaymentGrantedToken object</p>.
        /// </summary>
        public virtual Task<GrantedToken> GetAsync(string id, GrantedTokenGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<GrantedToken>(BaseAddress.Api, HttpMethod.Get, $"/v1/shared_payment/granted_tokens/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
