// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountInferredBalanceService : ServiceNested<AccountInferredBalance>,
        INestedListable<AccountInferredBalance, AccountInferredBalanceListOptions>
    {
        public AccountInferredBalanceService()
        {
        }

        public AccountInferredBalanceService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/financial_connections/accounts/{PARENT_ID}/inferred_balances";

        /// <summary>
        /// <p>Lists the recorded inferred balances for a Financial Connections <c>Account</c>.</p>.
        /// </summary>
        public virtual StripeList<AccountInferredBalance> List(string parentId, AccountInferredBalanceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<AccountInferredBalance>>(HttpMethod.Get, $"/v1/financial_connections/accounts/{parentId}/inferred_balances", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists the recorded inferred balances for a Financial Connections <c>Account</c>.</p>.
        /// </summary>
        public virtual Task<StripeList<AccountInferredBalance>> ListAsync(string parentId, AccountInferredBalanceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<AccountInferredBalance>>(HttpMethod.Get, $"/v1/financial_connections/accounts/{parentId}/inferred_balances", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists the recorded inferred balances for a Financial Connections <c>Account</c>.</p>.
        /// </summary>
        public virtual IEnumerable<AccountInferredBalance> ListAutoPaging(string parentId, AccountInferredBalanceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<AccountInferredBalance>($"/v1/financial_connections/accounts/{parentId}/inferred_balances", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists the recorded inferred balances for a Financial Connections <c>Account</c>.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<AccountInferredBalance> ListAutoPagingAsync(string parentId, AccountInferredBalanceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<AccountInferredBalance>($"/v1/financial_connections/accounts/{parentId}/inferred_balances", options, requestOptions, cancellationToken);
        }
    }
}
