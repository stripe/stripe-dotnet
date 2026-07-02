// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CustomerPaymentTokenService : Service,
        INestedListable<CustomerPaymentToken, CustomerPaymentTokenListOptions>
    {
        public CustomerPaymentTokenService()
        {
        }

        internal CustomerPaymentTokenService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public CustomerPaymentTokenService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Lists the Payment Tokens for a Crypto Customer.</p>.
        /// </summary>
        public virtual StripeList<CustomerPaymentToken> List(string parentId, CustomerPaymentTokenListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CustomerPaymentToken>>(BaseAddress.Api, HttpMethod.Get, $"/v1/crypto/customers/{WebUtility.UrlEncode(parentId)}/payment_tokens", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists the Payment Tokens for a Crypto Customer.</p>.
        /// </summary>
        public virtual Task<StripeList<CustomerPaymentToken>> ListAsync(string parentId, CustomerPaymentTokenListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CustomerPaymentToken>>(BaseAddress.Api, HttpMethod.Get, $"/v1/crypto/customers/{WebUtility.UrlEncode(parentId)}/payment_tokens", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists the Payment Tokens for a Crypto Customer.</p>.
        /// </summary>
        public virtual IEnumerable<CustomerPaymentToken> ListAutoPaging(string parentId, CustomerPaymentTokenListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CustomerPaymentToken>($"/v1/crypto/customers/{WebUtility.UrlEncode(parentId)}/payment_tokens", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists the Payment Tokens for a Crypto Customer.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<CustomerPaymentToken> ListAutoPagingAsync(string parentId, CustomerPaymentTokenListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CustomerPaymentToken>($"/v1/crypto/customers/{WebUtility.UrlEncode(parentId)}/payment_tokens", options, requestOptions, cancellationToken);
        }
    }
}
