namespace Stripe
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    [Obsolete("Use CustomerCashBalanceService instead.")]
    public class CashBalanceService : ServiceNested<CashBalance>
    {
        public CashBalanceService()
        {
        }

        internal CashBalanceService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public CashBalanceService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves a customer’s cash balance.</p>.
        /// </summary>
        public virtual CashBalance Get(string parentId, CashBalanceGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CashBalance>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{parentId}/cash_balance", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a customer’s cash balance.</p>.
        /// </summary>
        public virtual Task<CashBalance> GetAsync(string parentId, CashBalanceGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CashBalance>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{parentId}/cash_balance", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Changes the settings on a customer’s cash balance.</p>.
        /// </summary>
        public virtual CashBalance Update(string parentId, CashBalanceUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<CashBalance>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{parentId}/cash_balance", options, requestOptions);
        }

        /// <summary>
        /// <p>Changes the settings on a customer’s cash balance.</p>.
        /// </summary>
        public virtual Task<CashBalance> UpdateAsync(string parentId, CashBalanceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CashBalance>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{parentId}/cash_balance", options, requestOptions, cancellationToken);
        }
    }
}
