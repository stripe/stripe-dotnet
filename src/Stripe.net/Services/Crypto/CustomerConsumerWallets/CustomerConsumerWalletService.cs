// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CustomerConsumerWalletService : Service,
        INestedListable<CustomerConsumerWallet, CustomerConsumerWalletListOptions>
    {
        public CustomerConsumerWalletService()
        {
        }

        internal CustomerConsumerWalletService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public CustomerConsumerWalletService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Lists the Consumer Wallets for a Crypto Customer.</p>.
        /// </summary>
        public virtual StripeList<CustomerConsumerWallet> List(string parentId, CustomerConsumerWalletListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CustomerConsumerWallet>>(BaseAddress.Api, HttpMethod.Get, $"/v1/crypto/customers/{WebUtility.UrlEncode(parentId)}/crypto_consumer_wallets", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists the Consumer Wallets for a Crypto Customer.</p>.
        /// </summary>
        public virtual Task<StripeList<CustomerConsumerWallet>> ListAsync(string parentId, CustomerConsumerWalletListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CustomerConsumerWallet>>(BaseAddress.Api, HttpMethod.Get, $"/v1/crypto/customers/{WebUtility.UrlEncode(parentId)}/crypto_consumer_wallets", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists the Consumer Wallets for a Crypto Customer.</p>.
        /// </summary>
        public virtual IEnumerable<CustomerConsumerWallet> ListAutoPaging(string parentId, CustomerConsumerWalletListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CustomerConsumerWallet>($"/v1/crypto/customers/{WebUtility.UrlEncode(parentId)}/crypto_consumer_wallets", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists the Consumer Wallets for a Crypto Customer.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<CustomerConsumerWallet> ListAutoPagingAsync(string parentId, CustomerConsumerWalletListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CustomerConsumerWallet>($"/v1/crypto/customers/{WebUtility.UrlEncode(parentId)}/crypto_consumer_wallets", options, requestOptions, cancellationToken);
        }
    }
}
