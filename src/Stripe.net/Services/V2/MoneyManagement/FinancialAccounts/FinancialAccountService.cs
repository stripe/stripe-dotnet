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
        public virtual V2.FinancialAccount Get(string id, FinancialAccountGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.FinancialAccount>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/financial_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the details of an existing FinancialAccount.
        /// </summary>
        public virtual Task<V2.FinancialAccount> GetAsync(string id, FinancialAccountGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.FinancialAccount>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/financial_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Lists FinancialAccounts in this compartment.
        /// </summary>
        public virtual V2.StripeList<V2.FinancialAccount> List(FinancialAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.FinancialAccount>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/financial_accounts", options, requestOptions);
        }

        /// <summary>
        /// Lists FinancialAccounts in this compartment.
        /// </summary>
        public virtual Task<V2.StripeList<V2.FinancialAccount>> ListAsync(FinancialAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.FinancialAccount>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/financial_accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Lists FinancialAccounts in this compartment.
        /// </summary>
        public virtual IEnumerable<V2.FinancialAccount> ListAutoPaging(FinancialAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<V2.FinancialAccount>($"/v2/money_management/financial_accounts", options, requestOptions);
        }

        /// <summary>
        /// Lists FinancialAccounts in this compartment.
        /// </summary>
        public virtual IAsyncEnumerable<V2.FinancialAccount> ListAutoPagingAsync(FinancialAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<V2.FinancialAccount>($"/v2/money_management/financial_accounts", options, requestOptions, cancellationToken);
        }
    }
}
