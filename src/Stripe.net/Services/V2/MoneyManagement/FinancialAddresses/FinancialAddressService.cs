// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class FinancialAddressService : Service
    {
        internal FinancialAddressService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal FinancialAddressService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Create a new FinancialAddress for a FinancialAccount.
        /// </summary>
        public virtual FinancialAddress Create(FinancialAddressCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<FinancialAddress>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/financial_addresses", options, requestOptions);
        }

        /// <summary>
        /// Create a new FinancialAddress for a FinancialAccount.
        /// </summary>
        public virtual Task<FinancialAddress> CreateAsync(FinancialAddressCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancialAddress>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/financial_addresses", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a FinancialAddress. By default, the FinancialAddress will be returned in it's
        /// unexpanded state, revealing only the last 4 digits of the account number.
        /// </summary>
        public virtual FinancialAddress Get(string id, FinancialAddressGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FinancialAddress>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/financial_addresses/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a FinancialAddress. By default, the FinancialAddress will be returned in it's
        /// unexpanded state, revealing only the last 4 digits of the account number.
        /// </summary>
        public virtual Task<FinancialAddress> GetAsync(string id, FinancialAddressGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancialAddress>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/financial_addresses/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all FinancialAddresses for a FinancialAccount.
        /// </summary>
        public virtual V2.StripeList<FinancialAddress> List(FinancialAddressListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<FinancialAddress>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/financial_addresses", options, requestOptions);
        }

        /// <summary>
        /// List all FinancialAddresses for a FinancialAccount.
        /// </summary>
        public virtual Task<V2.StripeList<FinancialAddress>> ListAsync(FinancialAddressListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<FinancialAddress>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/financial_addresses", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all FinancialAddresses for a FinancialAccount.
        /// </summary>
        public virtual IEnumerable<FinancialAddress> ListAutoPaging(FinancialAddressListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<FinancialAddress>($"/v2/money_management/financial_addresses", options, requestOptions);
        }

        /// <summary>
        /// List all FinancialAddresses for a FinancialAccount.
        /// </summary>
        public virtual IAsyncEnumerable<FinancialAddress> ListAutoPagingAsync(FinancialAddressListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<FinancialAddress>($"/v2/money_management/financial_addresses", options, requestOptions, cancellationToken);
        }
    }
}
