// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CustomerService : Service,
        IRetrievable<Customer, CustomerGetOptions>
    {
        private CustomerConsumerWalletService consumerWallets;
        private CustomerPaymentTokenService paymentTokens;

        public CustomerService()
        {
        }

        internal CustomerService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public CustomerService(IStripeClient client)
            : base(client)
        {
        }

        public virtual CustomerConsumerWalletService ConsumerWallets => this.consumerWallets ??= new CustomerConsumerWalletService(
            this.Requestor);

        public virtual CustomerPaymentTokenService PaymentTokens => this.paymentTokens ??= new CustomerPaymentTokenService(
            this.Requestor);

        /// <summary>
        /// <p>Retrieves the details of a Crypto Customer.</p>.
        /// </summary>
        public virtual Customer Get(string id, CustomerGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Customer>(BaseAddress.Api, HttpMethod.Get, $"/v1/crypto/customers/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of a Crypto Customer.</p>.
        /// </summary>
        public virtual Task<Customer> GetAsync(string id, CustomerGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Customer>(BaseAddress.Api, HttpMethod.Get, $"/v1/crypto/customers/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
