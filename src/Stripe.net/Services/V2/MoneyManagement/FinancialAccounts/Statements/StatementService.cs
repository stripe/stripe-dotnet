// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement.FinancialAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class StatementService : Service
    {
        internal StatementService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal StatementService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieves the details of a Financial Account Statement.
        /// </summary>
        public virtual V2.MoneyManagement.FinancialAccountStatement Get(string parentId, string id, StatementGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.MoneyManagement.FinancialAccountStatement>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/financial_accounts/{WebUtility.UrlEncode(parentId)}/statements/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the details of a Financial Account Statement.
        /// </summary>
        public virtual Task<V2.MoneyManagement.FinancialAccountStatement> GetAsync(string parentId, string id, StatementGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.MoneyManagement.FinancialAccountStatement>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/financial_accounts/{WebUtility.UrlEncode(parentId)}/statements/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of statements for a Financial Account.
        /// </summary>
        public virtual V2.StripeList<V2.MoneyManagement.FinancialAccountStatement> List(string id, StatementListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.MoneyManagement.FinancialAccountStatement>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/financial_accounts/{WebUtility.UrlEncode(id)}/statements", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of statements for a Financial Account.
        /// </summary>
        public virtual Task<V2.StripeList<V2.MoneyManagement.FinancialAccountStatement>> ListAsync(string id, StatementListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.MoneyManagement.FinancialAccountStatement>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/financial_accounts/{WebUtility.UrlEncode(id)}/statements", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of statements for a Financial Account.
        /// </summary>
        public virtual IEnumerable<V2.MoneyManagement.FinancialAccountStatement> ListAutoPaging(string id, StatementListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<V2.MoneyManagement.FinancialAccountStatement>($"/v2/money_management/financial_accounts/{WebUtility.UrlEncode(id)}/statements", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of statements for a Financial Account.
        /// </summary>
        public virtual IAsyncEnumerable<V2.MoneyManagement.FinancialAccountStatement> ListAutoPagingAsync(string id, StatementListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<V2.MoneyManagement.FinancialAccountStatement>($"/v2/money_management/financial_accounts/{WebUtility.UrlEncode(id)}/statements", options, requestOptions, cancellationToken);
        }
    }
}
