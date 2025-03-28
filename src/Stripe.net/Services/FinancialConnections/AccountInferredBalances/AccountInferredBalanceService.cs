// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountInferredBalanceService : Service,
        INestedListable<AccountInferredBalance, AccountInferredBalanceListOptions>
    {
        public AccountInferredBalanceService()
        {
        }

        internal AccountInferredBalanceService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public AccountInferredBalanceService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Lists the recorded inferred balances for a Financial Connections <c>Account</c>.</p>.
        /// </summary>
        public virtual StripeList<AccountInferredBalance> List(string parentId, AccountInferredBalanceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<AccountInferredBalance>>(BaseAddress.Api, HttpMethod.Get, $"/v1/financial_connections/accounts/{WebUtility.UrlEncode(parentId)}/inferred_balances", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists the recorded inferred balances for a Financial Connections <c>Account</c>.</p>.
        /// </summary>
        public virtual Task<StripeList<AccountInferredBalance>> ListAsync(string parentId, AccountInferredBalanceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<AccountInferredBalance>>(BaseAddress.Api, HttpMethod.Get, $"/v1/financial_connections/accounts/{WebUtility.UrlEncode(parentId)}/inferred_balances", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists the recorded inferred balances for a Financial Connections <c>Account</c>.</p>.
        /// </summary>
        public virtual IEnumerable<AccountInferredBalance> ListAutoPaging(string parentId, AccountInferredBalanceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<AccountInferredBalance>($"/v1/financial_connections/accounts/{WebUtility.UrlEncode(parentId)}/inferred_balances", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists the recorded inferred balances for a Financial Connections <c>Account</c>.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<AccountInferredBalance> ListAutoPagingAsync(string parentId, AccountInferredBalanceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<AccountInferredBalance>($"/v1/financial_connections/accounts/{WebUtility.UrlEncode(parentId)}/inferred_balances", options, requestOptions, cancellationToken);
        }
    }
}
