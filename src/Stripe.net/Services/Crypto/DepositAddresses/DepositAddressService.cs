// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class DepositAddressService : Service,
        ICreatable<DepositAddress, DepositAddressCreateOptions>,
        IListable<DepositAddress, DepositAddressListOptions>,
        IRetrievable<DepositAddress, DepositAddressGetOptions>
    {
        public DepositAddressService()
        {
        }

        internal DepositAddressService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public DepositAddressService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a new crypto deposit address for the authenticated merchant on the specified
        /// network. The returned address can be used across multiple PaymentIntents.</p>.
        /// </summary>
        public virtual DepositAddress Create(DepositAddressCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<DepositAddress>(BaseAddress.Api, HttpMethod.Post, $"/v1/crypto/deposit_addresses", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new crypto deposit address for the authenticated merchant on the specified
        /// network. The returned address can be used across multiple PaymentIntents.</p>.
        /// </summary>
        public virtual Task<DepositAddress> CreateAsync(DepositAddressCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<DepositAddress>(BaseAddress.Api, HttpMethod.Post, $"/v1/crypto/deposit_addresses", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing crypto deposit address by ID.</p>.
        /// </summary>
        public virtual DepositAddress Get(string id, DepositAddressGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<DepositAddress>(BaseAddress.Api, HttpMethod.Get, $"/v1/crypto/deposit_addresses/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing crypto deposit address by ID.</p>.
        /// </summary>
        public virtual Task<DepositAddress> GetAsync(string id, DepositAddressGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<DepositAddress>(BaseAddress.Api, HttpMethod.Get, $"/v1/crypto/deposit_addresses/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists crypto deposit addresses for the authenticated merchant. Supports cursor-based
        /// pagination and optional filtering by customer, network, or on-chain address.</p>.
        /// </summary>
        public virtual StripeList<DepositAddress> List(DepositAddressListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<DepositAddress>>(BaseAddress.Api, HttpMethod.Get, $"/v1/crypto/deposit_addresses", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists crypto deposit addresses for the authenticated merchant. Supports cursor-based
        /// pagination and optional filtering by customer, network, or on-chain address.</p>.
        /// </summary>
        public virtual Task<StripeList<DepositAddress>> ListAsync(DepositAddressListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<DepositAddress>>(BaseAddress.Api, HttpMethod.Get, $"/v1/crypto/deposit_addresses", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists crypto deposit addresses for the authenticated merchant. Supports cursor-based
        /// pagination and optional filtering by customer, network, or on-chain address.</p>.
        /// </summary>
        public virtual IEnumerable<DepositAddress> ListAutoPaging(DepositAddressListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<DepositAddress>($"/v1/crypto/deposit_addresses", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists crypto deposit addresses for the authenticated merchant. Supports cursor-based
        /// pagination and optional filtering by customer, network, or on-chain address.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<DepositAddress> ListAutoPagingAsync(DepositAddressListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<DepositAddress>($"/v1/crypto/deposit_addresses", options, requestOptions, cancellationToken);
        }
    }
}
