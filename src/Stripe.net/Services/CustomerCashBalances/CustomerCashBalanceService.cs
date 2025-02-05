// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CustomerCashBalanceService : ServiceNested<CashBalance>
    {
        public CustomerCashBalanceService()
        {
        }

        internal CustomerCashBalanceService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public CustomerCashBalanceService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves a customer’s cash balance.</p>.
        /// </summary>
        public virtual CashBalance Get(string parentId, CustomerCashBalanceGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CashBalance>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/cash_balance", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a customer’s cash balance.</p>.
        /// </summary>
        public virtual Task<CashBalance> GetAsync(string parentId, CustomerCashBalanceGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CashBalance>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/cash_balance", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Changes the settings on a customer’s cash balance.</p>.
        /// </summary>
        public virtual CashBalance Update(string parentId, CustomerCashBalanceUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<CashBalance>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/cash_balance", options, requestOptions);
        }

        /// <summary>
        /// <p>Changes the settings on a customer’s cash balance.</p>.
        /// </summary>
        public virtual Task<CashBalance> UpdateAsync(string parentId, CustomerCashBalanceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CashBalance>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/cash_balance", options, requestOptions, cancellationToken);
        }
    }
}
