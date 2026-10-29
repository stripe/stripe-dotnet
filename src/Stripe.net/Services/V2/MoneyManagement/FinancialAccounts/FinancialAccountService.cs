// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class FinancialAccountService : Service
    {
        internal FinancialAccountService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal FinancialAccountService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieves the details of an existing FinancialAccount.
        /// </summary>
        public virtual FinancialAccount Get(string id, FinancialAccountGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FinancialAccount>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/financial_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the details of an existing FinancialAccount.
        /// </summary>
        public virtual Task<FinancialAccount> GetAsync(string id, FinancialAccountGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancialAccount>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/financial_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of FinancialAccounts in your account that match the provided filters.
        /// </summary>
        public virtual V2.StripeList<FinancialAccount> List(FinancialAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<FinancialAccount>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/financial_accounts", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of FinancialAccounts in your account that match the provided filters.
        /// </summary>
        public virtual Task<V2.StripeList<FinancialAccount>> ListAsync(FinancialAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<FinancialAccount>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/financial_accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of FinancialAccounts in your account that match the provided filters.
        /// </summary>
        public virtual IEnumerable<FinancialAccount> ListAutoPaging(FinancialAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<FinancialAccount>($"/v2/money_management/financial_accounts", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of FinancialAccounts in your account that match the provided filters.
        /// </summary>
        public virtual IAsyncEnumerable<FinancialAccount> ListAutoPagingAsync(FinancialAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<FinancialAccount>($"/v2/money_management/financial_accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Updates an existing FinancialAccount using the provided parameters.
        /// </summary>
        public virtual FinancialAccount Update(string id, FinancialAccountUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<FinancialAccount>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/financial_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Updates an existing FinancialAccount using the provided parameters.
        /// </summary>
        public virtual Task<FinancialAccount> UpdateAsync(string id, FinancialAccountUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancialAccount>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/financial_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
